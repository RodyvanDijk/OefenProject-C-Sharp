// See https://aka.ms/new-console-template for more information
//Console.Write("Geef je naam in: ");
//string naam = Console.ReadLine();

//Console.Write("Geef je leeftijd in: ");
//string leeftijd = Console.ReadLine();

//Console.WriteLine("Hallo " + naam + ", jij bent " + leeftijd + " jaar oud.");
//Console.WriteLine($"Hallo {naam}, jij bent {leeftijd} jaar oud.");

//Console.WriteLine(Math.Round(9.49));

//Console.WriteLine(Math.Max(8.56, 3.56));

//Console.WriteLine(Math.Abs(-2.32 + -6));

//string tekst = "Woord";
//Console.WriteLine("De lengte van dit woord is: " + tekst.Length);
//Console.WriteLine("De lengte van dit (" + tekst + ") woord is: " + tekst.Length + " letters");

//string tekst1 = "Voornaam";
//string tekst2 = "Achternaam";
//string volledigeTekst = tekst1 +" "+ tekst2;

//Console.WriteLine(volledigeTekst);
//Console.WriteLine(tekst1[3]);
//Console.WriteLine(tekst1.IndexOf('r'));

//float x = 4.8f;
//float y = 4.8f;

//if(x > y)
//{
//    Console.WriteLine(x + " is groter dan " + y);
//}
//else if(x == y)
//{
//    Console.WriteLine("De getallen zijn gelijk");
//}
//else
//{
//    Console.WriteLine(x + " is niet groter dan " + y);
//}

/*
bool regen = false;
bool koudWeer = false;

if(regen == true && koudWeer)
{
    Console.WriteLine("Het is koud en regen-achtig");
}else if(regen == false && koudWeer)
{
    Console.WriteLine("Het is koud maar droog");
}else if(regen  == true && !koudWeer)
{
    Console.WriteLine("Het is niet koud maar wel regen-achtig");
}
else
{
    Console.WriteLine("Het is niet koud en het is droog");
}
*/


try
{
    Console.Write("Geef getal 1: ");
    int getal1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Geef getal 2: ");
    int getal2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Welke bewerking wil je uitvoeren ( + , - , * , / ): ");
    string bewerking = Console.ReadLine();

    if (bewerking == "+")
    {
        Console.WriteLine(getal1 + getal2);
    }
    else if (bewerking == "-")
    {
        Console.WriteLine(getal1 - getal2);
    }
    else if (bewerking == "*")
    {
        Console.WriteLine(getal1 * getal2);
    }
    else if (bewerking == "/")
    {
        Console.WriteLine(getal1 / getal2);
    }
    else
    {
        Console.WriteLine("Incorrecte bewerking opgegeven");
    }
}
catch
{
    Console.WriteLine("Ongeldige waarden");
}


/*
int dag = 4;

switch (dag)
{
    case 1:
        Console.WriteLine("Maandag");
        break;
    case 2:
        Console.WriteLine("Dinsdag");
        break;
    case 3:
        Console.WriteLine("Woensdag");
        break;
    case 4:
        Console.WriteLine("Donderdag");
        break;
    case 5:
        Console.WriteLine("Vrijdag");
        break;
    case 6:
        Console.WriteLine("Zaterdag");
        break;
    case 7:
        Console.WriteLine("Zondag");
        break;
}
*/

/*
int i = 0;

while (i <= 20)
{
    Console.WriteLine(i);
    i += 5;
}
*/

/*
for(int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
}
*/

/*
string[] automerken = { "BMW", "Ford", "Mercedes", "Volvo" };
foreach(string merk in automerken)
{
    Console.WriteLine(merk);
}
*/

/*
string[] autos = { "BMW", "Ford", "Mercedes", "Volvo" };
Array.Sort(autos);
foreach (string i in autos)
{
    Console.WriteLine(i);
}
*/

/*
 * uhhhhhh
static void Main(string[] args)
{
    HalloZeggen("Rody");
}
*/

/*
HalloZeggen("Rody");
static void HalloZeggen(string naam)
{
    Console.WriteLine("Hallo " + naam);
}
*/
/*
 //Number guessing game for practice
Random r = new Random();

int winNum = r.Next(0, 100);

bool win = false;

do
{
    Console.WriteLine("Guess a number inbetween 0 and 100");
    string s = Console.ReadLine();

    int i = int.Parse(s);

    if(i > winNum)
    {
        Console.WriteLine("To high, guess lower!");
    }else if(i < winNum)
    {
        Console.WriteLine("To low, guess higher!");
    }else if(i == winNum)
    {
        Console.WriteLine("YOU WIN!");
        win = true;
    }

    Console.WriteLine();
} while (win == false);

Console.WriteLine("Thank you for playing the game!");
Console.Write("Press any key to finish!");
Console.ReadKey(true);
*/

