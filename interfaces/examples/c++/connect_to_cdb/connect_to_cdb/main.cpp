//+============================================================================+
//| Company:   SOFiSTiK AG                                                     |
//| Version:   SOFiSTIK 2018                                                   |
//+============================================================================+

// ToDo (troubleshooting):
// =======================
// 1. Copy all DLLs from "...ANALYSIS_50_X64\interfaces\64bit_debug" to "...interfaces\examples\c++\connect_to_cdb\x64\Debug"
// 2. Copy the icudt57.dll, icuin57.dll and icuuc57.dll to "...interfaces\examples\c++\connect_to_cdb\x64\Debug"
// 3. Add "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018" to environment PATH variable (not required, but recommended)

#include <iostream>
#include <Windows.h>
#include <string>

using namespace std;
typedef int(*INITPRT)(char*, int);
typedef int(*STATUSPRT)(int);
typedef int(*CLOSEPRT)(int);

int main()
{
	// In this example debug 64bit dlls are used (Visual Studio Platform 64bit)

	// Load the library
	HINSTANCE hInst = LoadLibrary("cdb_w50_x64d.dll");
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
		return EXIT_FAILURE;
	}

	CLOSEPRT sof_cdb_close = (CLOSEPRT)GetProcAddress(hInst, "sof_cdb_close");
	if(!sof_cdb_close)
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
	char* fileName = "S:\\test\\cdbPath.cdb";
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

	// Close the CDB
	// int sof_cdb_close  (int ie);
	sof_cdb_close(0);
	cout << "The CDB Status after closing: " << sof_cdb_status(ie) << endl;

	system("pause");
	return 0;
}