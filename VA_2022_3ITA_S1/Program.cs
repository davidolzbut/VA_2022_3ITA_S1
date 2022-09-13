// See https://aka.ms/new-console-template for more information
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_2022_3ITA_S1
{
    internal class ProgramNejvetsiBoreckaNaSvete
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
        }

    }
}
*/
// jednoradkova poznamka
/*
strana_a
jmenoNejvyssiHoryCeskeRepubliky
JmenoNejvyssiHoryCeskeRepubliky
_variableA
vysledek


do
    return
        while
        private
    else

    get
        remove
        select
    value
*/


// -2^31 <> 2^31 - 1
using VA_2022_3ITA_S1;

int stranaA = 10;
int stranaB = 15;

// -2^63 <> 2^63 - 1
long stranaC = 42L;

long c = stranaB + stranaA;

// -2^38 <> 2^38 - 1
float desetinneCisloA = 0.42F;

// -2^300 <> 2^300 - 1
double desetinneCisloB = 0.42;

decimal prachy = 0.42M;

bool pravda = true;
bool nepravda = false;

var promenna = 10;

string jmeno = "David";
char a = 'S';

int cislo;

Console.Write("Strana A");
string vstup = Console.ReadLine(); 

stranaA = Int32.Parse(vstup);

Console.Write("Strana B");
vstup = Console.ReadLine(); 

stranaB = Int32.Parse(vstup);

int obvod = (stranaA + stranaB) * 2;
int obsah = stranaA * stranaB;

Console.Write("Obvod je: ");
Console.Write(obvod);
Console.Write("cm");
Console.WriteLine();

Console.WriteLine("Obvod je: " + obvod.ToString() + "cm");
Console.WriteLine($"Obsah je: {obsah} cm^2");


//STOP
Console.Write("Pro ukončení programu stiskni klávesu ENTER!");
Console.ReadLine();

