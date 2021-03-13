//+============================================================================+
//| Company:   SOFiSTiK AG                                                     |
//| Version:   SOFiSTIK 2018                                                   |
//+============================================================================+

// ToDo (troubleshooting)
// ======================
// 1. Project Properties -> C/C++ -> General -> Additional Include Directories and add 
//    "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\examples\c++"
// 2. Copy all DLLs from "...ANALYSIS_50_X64\interfaces\64bit_debug" to "...interfaces\examples\c++\read_nodes\x64\Debug"
// 3. Copy the icudt57.dll, icuin57.dll and icuuc57.dll from "ANALYSIS_50_X64" to "...interfaces\examples\c++\read_nodes\x64\Debug" 
// 4. Add "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018" to environment PATH variable (not required, but recommended)

#include <iostream>
#include <Windows.h>
#include <string>
#include <iomanip>

// Include SOFiSTiK Libraries
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
typedef int(*INITPRT)(char*, int);
typedef int(*STATUSPRT)(int);
typedef int(*CLOSEPRT)(int);
typedef int(*GETPRT)(int, int, int, void*, int*, int);

int main()
{
	// Load the library
	HINSTANCE hInst = LoadLibrary("C:\\Program Files\\SOFiSTiK\\2018\\SOFiSTiK 2018\\interfaces\\64bit_debug\\cdb_w50_x64d.dll");
	if(!hInst)
	{
		cout << "Coult not Load the Library" << endl;
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
		return EXIT_FAILURE;
	}

	// Connect to CDB
	// int sof_cdb_init  ( char* FileName, int Index);

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
	char* fileName = "read_nodes.cdb";
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

	// Get Status
	// int sof_cdb_status  (int ie);
	cout << "The CDB Status: " << sof_cdb_status(ie) << endl;

	int datalen = sizeof(tagCDB_NODE);
	int *datalenptr;
	datalenptr = &datalen;
	tagCDB_NODE cnode;
	
	cout << setw(11) << "nr"
		 << setw(11) << "inr" 
		 << setw(11) << "kfix"
		 << setw(11) << "ncod" 
		 << setw(20) << "x" 
		 << setw(20) << "y"
		 << setw(20) << "z" <<  endl;
	// &cnode pass the adress of the struct to pointer
	while (sof_cdb_get(ie, 20, 0, &cnode, &datalen, 1) < 2)	
	{
		cout << setw(11) << cnode.m_nr 
			 << setw(11) << cnode.m_inr 
			 << setw(11) << cnode.m_kfix 
			 << setw(11) << cnode.m_ncod 
			 << setw(20) << cnode.m_xyz[0] 
			 << setw(20) << cnode.m_xyz[1] 
			 << setw(20) << cnode.m_xyz[2] 
			 <<  endl;
	}

	// Close the CDB
	// int sof_cdb_close  (int ie);
	sof_cdb_close(0);
	cout << "The CDB Status after closing: " << sof_cdb_status(ie) << endl;

	system("pause");
	return 0;
}