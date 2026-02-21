//casting implicito
using System.ComponentModel;

int valor = 200;
double total = valor;
Console.WriteLine("implicito: " + total);

//casting explicito
double precio = 500.23;
int descuento = (int)precio; 

Console.WriteLine("EXplicito: "+ descuento);


char letra = 'A';
int codigoAsci = letra;
Console.WriteLine(codigoAsci);


string palabra = "123456";
int numero = Convert.ToInt32 (palabra);
Console.WriteLine(numero);

string textoDecmial = "150.60";
double valor3 = double.Parse (textoDecmial);
Console.WriteLine(valor3);


Console.ReadLine();