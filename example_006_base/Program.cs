int a = 2;
int b = 4;
int c = 1;
int d = 9;
int f = 0;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

Console.Write ("max = ");
Console.WriteLine (max);