// ConsoleApplication6.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#import "ClassLibrary6.tlb" raw_interfaces_only

int wmain()
{
	CoInitialize(0);
	BSTR directory = ::SysAllocString(L"C:\\Users\\Jeekkee\\source\\repos\\ClassLibrary6\\ClassLibrary6\\bin\\Debug\\");
	BSTR successMsg;
	BSTR tobe = ::SysAllocString(L"Ey boss");

	ClassLibrary6::_Class1Ptr obj(__uuidof(ClassLibrary6::Class1));
	HRESULT hResult = obj->WriteFiles(directory, tobe, &successMsg);

		std::wcout << successMsg << std::endl;
	
	return 0;
}
