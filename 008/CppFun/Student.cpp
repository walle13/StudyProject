#include "Student.h"
#include<iostream>

Student::Student()
{

}

Student::~Student()
{

}

void  Student::SayHello()
{
	std::cout << "I'm a student! \n";
}

double Student::Add(double a, double b)
{
	return a + b;
}