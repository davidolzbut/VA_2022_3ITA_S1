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
*/

//const double pi = 3.14;

/*
    x == y
    x != y
    x > y
    x < y
    x >= y
    x <= y

    x = true
    y = false
    !x => false
    !y => true
    x && y => false
    x || y => true
    x && !y => true


Console.Write("Zadejte cislo pls => ");
int vstup = Int32.Parse(Console.ReadLine());

// (0, ∞)
if (vstup > 0)
{
    Console.WriteLine("Jedna se o prirozene cislo");
}
// <0,0> {0}
else if (vstup == 0)
{
    Console.WriteLine("Cislo je nula");
}
// (-∞, 0)
else
{
    Console.WriteLine("Jedna se o zaporne cislo");
}
 

Console.Write("Ma pizzerie otevreno? => ");
string pizzaOtevreno = Console.ReadLine();

Console.Write("Kolika mas penez? => ");
int penize = Int32.Parse(Console.ReadLine());

Console.Write("Kolik stoji pizza penizku? => ");
int cenaPizza = Int32.Parse(Console.ReadLine());

if (pizzaOtevreno == "ano")
{
    if (penize >= cenaPizza)
    {
        Console.WriteLine("Muzes si pizzu koupit!");
    }
    else
    {
        Console.WriteLine("nemas penize.. :-(");
    }
}
else
{
    Console.WriteLine("Pizzeria nema otevreno");
}

if ((pizzaOtevreno == "ano") && (penize >= cenaPizza))
{
    Console.WriteLine("Muzes si pizzu koupit!");
}
else if ((pizzaOtevreno == "ano") && (penize < cenaPizza))
{
    Console.WriteLine("nemas penize.. :-(");
}
else
{
    Console.WriteLine("Pizzeria nema otevreno");
}


Console.Write("Volba => ");
int volba = Int32.Parse(Console.ReadLine());

//CASE STATEMENT
switch (volba)
{
    // if (volba == 0)
    case 0:
        Console.WriteLine("Volba je: " + volba.ToString());
        break;
    case 1:
        Console.WriteLine("Volba je: " + volba.ToString());
        break;
    case 2:
        Console.WriteLine("Volba je: " + volba.ToString());
        break;
    case 3:
        Console.WriteLine("Volba je: " + volba.ToString());
        break;
    default:
        Console.WriteLine("Neznama volba..");
        break;

}
if (volba == 1)
{

}
else if (volba == 2)
{

}





int x = 0;
while(x > 0)
{
    Console.WriteLine("A");
    //x = x - 1;
    x--;
}


//do-while
do
{
    Console.WriteLine("B");
    //x = x - 1;
    x--;
} while (x > 0);
*/

Console.Write("=>");
int vystup;
while (!Int32.TryParse(Console.ReadLine(), out vystup))
{
    Console.Write("=>");
}
Console.WriteLine(vystup);

int[] cisla = new int[3];
cisla[0] = 1;
cisla[1] = 2;
cisla[2] = 3;

//len(cisla)
for (int i = 0; i < cisla.Length; i++)
{
    Console.WriteLine(cisla[i]);
}

foreach (int cislo in cisla)
{
    Console.WriteLine(cislo);
}
/*
 *              
 Pouze prirozena cisla (cisla > 0)
    1 - soucet
    2 - pocet
    3 - prumer
    4 - maxCislo
    5 - minCislo
 
 */




//STOP
Console.Write(
      "Pro ukončení programu "
    + "stiskni klávesu \"ENTER\"!"
    );

Console.ReadLine();

