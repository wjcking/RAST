#include "stdafx.h"
#include "rebiz.h"
#include <string>
#include <iostream>

 #include <conio.h>
//#include <tchar.h>
//#include <stdio.h> 
//#include <boost/filesystem.hpp>
using namespace std;
void standot()
{
	printf("stand-out");
}
int main(int argc, char **argv)
{
	//char* a[] = { "hello world", "liitdar" };
	//char** b = a;
	// L'哀' unicode编码  没有L是ascii编码
	auto at=1;
	karact ket1 = '是';
	 cout<<ket1<<endl;
	//ls53c2zl=L'五';
	//ls8003zl='ھ';
	//auto tsd = (char*)"0123456789";
	//cout << tsd[2]<<":"<< sizeof(tsd)<< endl;
	//w_char wt;
	//wt ="啊是分";	
	wcout<<"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"<<endl;
	wcout.imbue(locale("chs"));

	//wcout << ls8003zl << " -> " << sizeof(ls8003zl) << endl;
	//wcout << ls53c2zl << " -> " << sizeof(ls53c2zl) << endl;
	 
	standot();
	 int ch;
    while (1){
        if (_kbhit()){//如果有按键按下，则_kbhit()函数返回真
            ch = _getch();//使用_getch()函数获取按下的键值
            cout << ch;
            if (ch == 27){ break; }//当按下ESC时循环，ESC键的键值时27.
        }
	}
	system("pause");

	return 0;
} 