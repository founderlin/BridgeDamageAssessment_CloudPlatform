//+============================================================================+
//| Company:   SOFiSTiK AG                                                     |
//| Version:   SOFiSTIK 2018                                                   |
//+============================================================================+


// ToDo (troubleshooting)
// ======================
// 1. Project Properties -> C/C++ -> General -> Additional Include Directories and add 
//    "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\examples\c++"
// 2. Copy all DLLs from "...ANALYSIS_50_X64\interfaces\64bit_debug" to "...interfaces\examples\c++\single_span_girder\x64\Debug"
// 3. Copy the icudt57.dll, icuin57.dll and icuuc57.dll from "ANALYSIS_50_X64" to "...interfaces\examples\c++\single_span_girder\x64\Debug" 
// 4. Add "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018" to environment PATH variable (not required, but recommended)

#include <iostream>
#include <Windows.h>
// Header providing parametric manipulators
#include <iomanip> 

// Include the SOFiSTiK Libraries
#include "cdbase.h"
#include "cdbtypeall.h"
#include "cdbtypecon.h"
#include "cdbtypegeo.h"
#include "cdbtypelfc.h"
#include "cdbtypemat.h"
#include "cdbtypesct.h"
#include "cdbtypesys.h"
#include "cdbtypeten.h"

using namespace std;

// Define the functions
typedef int(*INITPRT)(char*, int);				            // sof_cdb_init
typedef int(*STATUSPRT)(int);							         // sof_cdb_status
typedef int(*CLOSEPRT)(int);							         // sof_cdb_close
typedef int(*GETPRT)(int, int, int, void*, int*, int);	// sof_cdb_get
typedef int(*FLUSHPRT)(int);						            // sof_cdb_init

int main()
{
	// In this example debug 64bit dlls are used (Visual Studio Platform 64bit)
	HINSTANCE hInst = LoadLibrary("C:\\Program Files\\SOFiSTiK\\2018\\SOFiSTiK 2018\\interfaces\\64bit_debug\\cdb_w50_x64d.dll");
	if(!hInst)
	{
		cout << "Coult not Load the Library";
		system("pause");
		return EXIT_FAILURE;
	}

	// Resolve the function adress
	INITPRT sof_cdb_init = (INITPRT)GetProcAddress(hInst, "sof_cdb_init");
	if(!sof_cdb_init)
	{
		cout << "Could not locate the function!" << endl;
		system("pause");
		return EXIT_FAILURE;
	}

	STATUSPRT sof_cdb_status = (STATUSPRT)GetProcAddress(hInst, "sof_cdb_status");
	if(!sof_cdb_status)
	{
		cout << "Could not locate the function!" << endl;
		system("pause");
		return EXIT_FAILURE;
	}

	CLOSEPRT sof_cdb_close = (CLOSEPRT)GetProcAddress(hInst, "sof_cdb_close");
	if(!sof_cdb_close)
	{
		cout << "Could not locate the function!" << endl;
		system("pause");
		return EXIT_FAILURE;
	}

	GETPRT sof_cdb_get = (GETPRT)GetProcAddress(hInst, "sof_cdb_get");
	if(!sof_cdb_get)
	{
		cout << "Could not locate the function!" << endl;
		system("pause");
		return EXIT_FAILURE;
	}

	FLUSHPRT sof_cdb_flush = (FLUSHPRT)GetProcAddress(hInst, "sof_cdb_flush");
	if(!sof_cdb_flush)
	{
		cout << "Could not locate the function!" << endl;
		return EXIT_FAILURE;
	}

	// ******************************************************
	// * Connect to CDB										*
	// * int sof_cdb_init  ( char* FileName, int Index);	*
	// ******************************************************

	/*
	Index = 0     initialise CDBASE and open scratch data base only
	Index > 0     open an existing data base with exactly tis index
						(STATUS=UNKNOWN) = somehow obsolete call, use 99!
	 Index = 99    test if NAME is a valid database and open the base
						if possible. Return with the assigned index.
						If the file does not exist, it will be created.
	 Index = 97    open the database via pvm
						Return with the assigned index.
	 Index = 96    open a scratch database, filename is the path to
						use or NULL.
	 Index = 95    open in read-only mode
	 Index = 94    create a new data base (STATUS=NEW)
	 */
	int index = 99;

	// cdb path
	// char* fileName = "S:\\svn\\product\\fea\\interfaces\\2016\\programming\\redist\\interfaces\\examples\\c++\\simple_span_girder\\x64\\Debug\\simple_span_girder.cdb";
	char* fileName = "S:\\test\\single_span_girder\\single_span_girder.cdb";
	int ie = sof_cdb_init(fileName, index);
	if (ie < 0)
	{
		cout << "ERROR: Index= " << ie << " < 0 - see clib1.h for meaning of error codes" << endl;
		cout << "Press any <key> to close the program";
		system("pause");
		return(0);
	}
	else if(ie == 0)
	{
		cout << "ERROR: Index= " << ie << " - The File is not a database" << endl;
		cout << "Press any <key> to close the program";
		system("pause");
		return(0);
	}

	// **************************************************
	// * Read the data									*
	// * sof_cdb_get(int, int, int, void*, int*, int)	*
	// **************************************************

	// Length of the records
	int datalen;
	int *datalenptr;

	
	// -----------------------------
	// Read the f_ck value
	// -----------------------------
	double fck = 0.0;
	datalen = sizeof(tagCDB_MAT_CONC);
	datalenptr = &datalen;
	tagCDB_MAT_CONC c_mat_conc;
	while (sof_cdb_get(ie, 1, 1, &c_mat_conc, &datalen, 1) < 2)	
	{
		if (c_mat_conc.m_id == 1)
		{
			// devide with 1000 because of units kN/m^2 -> MN/m^2
			fck = c_mat_conc.m_fck / 1000;
		}
		datalen = sizeof(tagCDB_MAT_CONC);
	}


	// Release all locks. All memory for directories and data is released. 
	// Only after this call the directory structure is reread which allows the access to newly defined keys.
	sof_cdb_flush(ie);


	// -----------------------------
	// Read the f_y value
	// -----------------------------
	double fy = 0.0;
	datalen = sizeof(tagCDB_MAT_STEE);
	datalenptr = &datalen;
	tagCDB_MAT_STEE c_mat_stee;
	
	// kwh = 1, kwl = 2
	while (sof_cdb_get(ie, 1, 2, &c_mat_stee, &datalen, 1) < 2)	
	{
		if (c_mat_stee.m_id == 1)
		{
			// devide with 1000 because of units kN/m^2 -> MN/m^2
			fy = c_mat_stee.m_fy / 1000;	 
		}
		datalen = sizeof(tagCDB_MAT_STEE);
	}


	// Release all locks. All memory for directories and data is released. 
	// Only after this call the directory structure is reread which allows the access to newly defined keys.
	sof_cdb_flush(ie);

	
	// -----------------------------
	// Read the b, h, so, su values
	// -----------------------------
	double b = 0.0;
	double h = 0.0;
	double so = 0.0;
	double su = 0.0;
	datalen = sizeof(tagCDB_SECT_REC);
	datalenptr = &datalen;
	tagCDB_SECT_REC c_sect_rec;
	
	// kwh = 9, kwl = 1
	while (sof_cdb_get(ie, 9, 1, &c_sect_rec, &datalen, 1) < 2)	
	{
		if (c_sect_rec.m_id == 10)
		{
			b = c_sect_rec.m_b;	 
			h = c_sect_rec.m_h;
			so = c_sect_rec.m_so;
			su = c_sect_rec.m_su;
		}
		datalen = sizeof(tagCDB_SECT_REC);
	}


	// Release all locks. All memory for directories and data is released. 
	// Only after this call the directory structure is reread which allows the access to newly defined keys.
	sof_cdb_flush(ie);
	
	
	// -----------------------------
	// READ THE INTERNAL FORCES N, M
	// -----------------------------
	double Ned = 0.0;
	double Med = 0.0;
	datalen = sizeof(typeCDB_BEAM_FOC);
	datalenptr = &datalen;
	typeCDB_BEAM_FOC c_beam_foc;
	
	// kwh = 102, kwl = 1001
	while (sof_cdb_get(ie, 102, 1001, &c_beam_foc, &datalen, 1) < 2)	
	{
		if (c_beam_foc.m_id == 0)
		{
			if (abs(Ned) < abs(c_beam_foc.m_n) && (abs(c_beam_foc.m_n) < 1e35))
			{
				Ned = c_beam_foc.m_n / 1000;
			}

			if (abs(Med) < abs(c_beam_foc.m_my) && (abs(c_beam_foc.m_my) < 1e35))
			{
				Med = c_beam_foc.m_my / 1000;
			} 
		}
		datalen = sizeof(typeCDB_BEAM_FOC);
	}

	// Release all locks. All memory for directories and data is released. 
	// Only after this call the directory structure is reread which allows the access to newly defined keys.
	sof_cdb_flush(ie);


	// **************************************************
	// * CROSS SECTION DESIGN							*
	// * iterating the reinforcement to get equilibrium	*
	// **************************************************

	// declaring variables

	double epss = 25;
	 double epsc = 0;
	 double Mrd = 0;
	 double mu = 0;
	 double alpha = 0;
	 double xi = 0;
	 double x = 0;
	 double d = h - su;
	 double ka = 0;
	 double z = 0;
	 double zeta = 0;
	 double omega = 0;
	 double fcd = (fck * 0.85) / 1.5;
	 double fyd = fy / 1.15;
	 double As1 = 0;
	double Meds;

	Meds = Med - Ned * (h / 2 - su);

	// iterate the reinforcement
	while (Mrd <= Meds && mu <= 0.296)
	{
		if (epsc > 0 && epsc <= 2)
		{
			alpha = epsc / 12 * (6 - epsc);
		}
		else if (epsc > 2 && epsc <= 3.5)
		{
			alpha = (3 * epsc - 2) / (3 * epsc);
		}
		  
		// Calculate the Xi Value
		  xi = epsc / (epss + epsc);

		  // Calculate x
		  x = xi * d;

		  // Calculate ka
		  if (epsc > 0 && epsc <= 2)
		  {
				ka = (8 - epsc) / (4 * (6 - epsc));
		  }
		  else if (epsc > 2 && epsc <= 3.5)
		  {
				ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2));
		  }

		// Calculate z
		z = d - ka * x;
		
		// Calculate zeta
		zeta = 1 - ka * xi;
		
		// Calculate omega
		omega = alpha * xi;
		
		// Calculate mu
		// mu = alpha * xi * d * gv.b * Convert.ToSingle(fcd);         
		mu = alpha * xi * zeta;
		
		// Calculate the Mrd resistance moment
		Mrd = alpha * xi * d * b * fcd * zeta * d;
		
		// Required reinforcement
		As1 = (1 / fyd) * (omega * b * d * fcd + Ned);

		if (epsc >= 3.5)
		{
			 while (Mrd <= Meds && epss >= 0 && mu < 0.296)
			 {
				  if (epsc > 0 && epsc <= 2)
				  {
						alpha = epsc / 12 * (6 - epsc);
				  }
				  else if (epsc > 2 && epsc <= 3.5)
				  {
						alpha = (3 * epsc - 2) / (3 * epsc);
				  }
		
				  // Calculate the Xi Value
				  xi = epsc / (epss + epsc);
		
				  // Calculate x
				  x = xi * d;
		
				  // Calculate ka
				  if (epsc > 0 && epsc <= 2)
				  {
						ka = (8 - epsc) / (4 * (6 - epsc));
				  }
				  else if (epsc > 2 && epsc <= 3.5)
				  {
						ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2));
				  }
		
				  // Calculate z
				  z = d - ka * x;
		
				  // Calculate zeta
				  zeta = 1 - ka * xi;
		
				  // Calculate omega
				  omega = alpha * xi;
		
				  // Calculate mu
				  mu = alpha * xi * zeta;
		
				  // Calculate the Mrd resistance moment
				  Mrd = alpha * xi * d * b * fcd * zeta * d;
		
				  // Required reinforcement
				  As1 = (1 / fyd) * (omega * b * d * fcd + Ned);
		
				  if (epss == 0)
				  {
						cout << "Reinforced reached 0 [o/oo]";
				  }
		
				  // Iterate epss
				  epss = epss - 0.001;
			 }
		}
		 // Iterate epsc
		 epsc = epsc + 0.001;
	}

	cout << setw(10) << "fcd = " << setw(20) << fcd << setw(20) << "MPa" << endl;
	cout << setw(10) << "fyd = " << setw(20) << fyd << setw(20) << "MPa" << endl;
	cout << setw(10) << "epsc = " << setw(20) << epsc << setw(20) << "[o/oo]" << endl;
	cout << setw(10) << "epss = " << setw(20) << epss << setw(20) << "[o/oo]" << endl;
	cout << setw(10) << "alpha = " << setw(20) << alpha << setw(20) << "" << endl;
	cout << setw(10) << "ka = " << setw(20) << ka << setw(20) << "" << endl;
	cout << setw(10) << "z = " << setw(20) << z << setw(20) << "m" << endl;
	cout << setw(10) << "zeta = " << setw(20) << zeta << setw(20) << "" << endl;
	cout << setw(10) << "omega = " << setw(20) << omega << setw(20) << "" << endl;
	cout << setw(10) << "mu = " << setw(20) << mu << setw(20) << "" << endl;
	cout << setw(10) << "d = " << setw(20) << d << setw(20) << "m" << endl;
	cout << setw(10) << "Xi = " << setw(20) << xi << setw(20) << "" << endl;
	cout << setw(10) << "x = " << setw(20) << x << setw(20) << "m" << endl;
	cout << "------------" << endl;
	cout << setw(10) << "Mrds = " << setw(20) << Mrd << setw(20) << "MNm" << endl;
	cout << setw(10) << "As1 = " << setw(20) << As1 * 100 * 100 << setw(20) << "cm2" << endl;

	// Get Status
	// int sof_cdb_status  (int ie);
	cout << "The CDB Status: " << sof_cdb_status(ie) <<  endl;

	// Close the CDB
	// int sof_cdb_close  (int ie);
	sof_cdb_close(0);
	cout << "The CDB Status after closing: " << sof_cdb_status(ie) << endl;


	// Close the program
	system("pause");
	return 0;
}