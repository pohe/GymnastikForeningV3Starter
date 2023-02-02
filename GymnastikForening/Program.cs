// See https://aka.ms/new-console-template for more information

using GymnastikForening;
using Microsoft.VisualBasic;

Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 20);
Hold h2 = new Hold("Rollinger22s", 2022, "Rollinger", 700, 15);
Console.WriteLine(h1);
Console.WriteLine(h2);


HoldKatalog holdKatalog = new HoldKatalog();
try
{
    holdKatalog.TilføjHold(h1);
    holdKatalog.TilføjHold(h2);
}
catch(ArgumentException aex)
{
    Console.WriteLine("Fejl ved tilføjelse af hold");
}

Console.WriteLine(holdKatalog); //udskriving vha. ToString metode


Deltager d1 = new Deltager("Poul Henriksen", "Vej 123", 3);
Deltager d2 = new Deltager("Charlotte Heegaard", "Gade 321", -1);
Console.WriteLine(d1);
Console.WriteLine(d2);





Console.ReadLine();


