// dllmain.cpp : Defines the entry point for the DLL application.
#define EXPORTING_DLL
#include "dllTest.h"
#include <Windows.h>
#include <cmath>

BOOL APIENTRY DllMain( HMODULE hModule , DWORD  ul_reason_for_call , LPVOID lpReserved )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

int HelloWorld(int A)
{
	return (2 * A);
}



double compute(double A)
{
	return ( std::pow(A, 2.0) + 4*A + 3);
}























