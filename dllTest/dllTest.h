// dll.cpp : Defines the exported functions for the DLL application.
//

#ifdef EXPORTING_DLL
extern "C" __declspec(dllexport) int HelloWorld(int);
extern "C" __declspec(dllexport) double compute(double);
#else
extern "C" __declspec(dllimport) int HelloWorld(int);
extern "C" __declspec(dllimport) double compute(double);
#endif