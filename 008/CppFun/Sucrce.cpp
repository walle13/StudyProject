#include <iostream>
#include"Student.h"

double Add(double a, double b)
{
	return a + b;
}

int main()
{
	//std::cout << "Hello World!\n";
	//double x = 3.0;
	//double y = 5.0;
	//double result = Add(x, y); 
	//std::cout << x << "+" << y << "=" << result;
	Student* pStu = new Student();
	pStu->SayHello();
	double x = 4.0;
	double y = 5.0;
	double result = pStu->Add(x, y); //调用类的成员，类的方法
	std::cout << x << "+" << y << "=" << result;
	return 0;
}

