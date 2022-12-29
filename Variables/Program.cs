// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!"); 
Console.WriteLine("yo soy Rafael Morales Llanes");
Console.WriteLine("mi Edad es: " + 23);

//Este s un ejemplo de un bloque de codigo

{
    Console.WriteLine("este codigo esta dentro de un bloque");
}

//Este codigo permite escribir en la  consola


/*
 linea 
mas comentarois

*/
Console.WriteLine("este codigo No esta dentro de un bloque");


//Numeros Enteros

int edad;
edad = 180;
Console.WriteLine(edad);

int edadFelipe = 12;
Console.WriteLine(edadFelipe);

int distanciaDeLaTierraAlSolEnKilometros = 150_000_000;
Console.WriteLine(distanciaDeLaTierraAlSolEnKilometros);

int numeroMasGrande = int.MaxValue;
Console.WriteLine(numeroMasGrande);

int numeroMasMinimo = int.MinValue;
Console.WriteLine(numeroMasMinimo);

//Fin de numero Menores

byte byte1 = 145; //0 hasta 255 
Console.WriteLine(byte1);

sbyte sbyte1 = 100; // -128 hasta 127;

short short1 = 30_000; // desde 32,768 hasta 32,767

ushort usshort1 = 65_000; // desde 0 hasta 65,535

uint uint2 = 3_000_000_000; //desde 0 hasta 4 mil millones

long long1 = 8_000_000_000_000; // 64 bits
ulong ulong1 = 16_000_000_000_000; // 0  hasta 


float altura = 180.24f; //ocupa 4 bytes ; precicion de 6 a 9 digitos
double anchura = 45.99d; //ocupa 8 bytes ; precicion de 15 a 1 digitos
decimal monto = 9.99m; // ocupa 16 bytes; precicion de 28 a 29 digitod(recomendado a temas financieros)

Console.WriteLine("La anchura es " + anchura);
Console.WriteLine("La altura es " + altura);
Console.WriteLine("El monto es : " + monto);


bool soyRafa = true;
bool soyKato = false;

char ABC = 'A'; // solo se puede 1 caracter
string nombre = "Felipe";   // varios Caracteres
string texto = "Mi amigo me dijo una vez: \"me caes bien\" ";

Console.WriteLine(nombre);
Console.WriteLine(ABC);
Console.WriteLine(texto);


//string de varias lines 
string carta = @"A quien pueda interesar, 

Estimando cliente, debesw mucho dinero .

att: La administracion";

string directoriosDelArchivo = @"C:\Mis documentos\mi carpeta\excel.xlsx";

Console.WriteLine(directoriosDelArchivo);


//DateTime

DateTime ahora = DateTime.Now;
DateTime primerDiaDelAño = new DateTime(2022, 1, 1, 8,18,28);
DateTime mañana = DateTime.Now.AddDays(1);
Console.WriteLine(mañana.Day);
Console.WriteLine(primerDiaDelAño);
Console.WriteLine(ahora);


//Operacion binaria

var cantidad1 = 5;
var cantidad2 = 3;
var resultado = cantidad1 + cantidad2;
Console.WriteLine("La suma de: "+ cantidad1 + " + " + cantidad2 + " = "+ resultado);
Console.WriteLine($"La suma de {cantidad1} + {cantidad2} es igual a {resultado}");


