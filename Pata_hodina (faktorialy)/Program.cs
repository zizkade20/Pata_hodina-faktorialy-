using System.Diagnostics.CodeAnalysis;

Random rnd = new Random();
int n = rnd.Next(1, 100);


int soucet = 0;
int faktorial;
int odmocnina;
int cifsou = 0;
int jedna;
int pozpatku;

// SOUCET --------------
for (int i = 1; i < n; i++)
{
    soucet += n;
}



Console.WriteLine(n);
Console.WriteLine("součet: " + soucet);
Console.WriteLine("faktoriál:");




int suma = 0;
while (n != 0)
{
    suma += n % 10;
    n /= 10;
}
Console.WriteLine("ciferný součet: " + suma);



















