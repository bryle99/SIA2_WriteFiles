#include <Windows.h>
#include <iostream>


using namespace std;
int _tmain(int argc, _TCHAR* argv[])
{
	HMODULE dll = LoadLibrary(L"WriteFiles_Dll.dll");
	if (NULL != dll) {
		AvVersion func = (AvVersion)GetProcAddress(dll, "avodec_version");
		if (NULL != func) {
			unsigned int result = func();
			cout << "Version: " << result endl;
		}
		else {
			cout << "I cant load_version function";
		}
	}
	else {
		cout << "Cant load file";
	}
		return 0;
}
