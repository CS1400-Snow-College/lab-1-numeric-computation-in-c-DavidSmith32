﻿Console.Clear();
//Step 1
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

c = a * b;
Console.WriteLine(c);

c = a / b;
Console.WriteLine(c);

//Step 2
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

d = (a + b) / c;
Console.WriteLine(d);

//Step 3
a = 7;
b = 4;
c = 3;
d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

//Step 4
double f = 5;
double g = 4;
double h = 2;
double i = (f + g) / h;
Console.WriteLine(i);

f = 19;
g = 23;
h = 8;
i = (f + g) / h;
Console.WriteLine(i);

double max2 = double.MaxValue;
double min2 = double.MinValue;
Console.WriteLine($"The range of double is {min2} to {max2}");

double third = 1.0 / 3.0;
Console.WriteLine(third);