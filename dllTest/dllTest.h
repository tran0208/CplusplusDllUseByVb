// dll.cpp : Defines the exported functions for the DLL application.
//

#ifdef EXPORTING_DLL
extern "C" __declspec(dllexport) int HelloWorld(int);
#else
extern "C" __declspec(dllimport) int HelloWorld(int);
#endif