#include <stdio.h>

double Add(double a,double b)
{
	return a + b;
}


void main()
{
	printf("Hello World!\n");
	double x = 3.0;
	double y = 5.0;
	double result = Add(x, y);
	printf("%f+%f=%f", x, y, result);
	return 0;
}

