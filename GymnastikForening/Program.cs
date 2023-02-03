// See https://aka.ms/new-console-template for more information

using GymnastikForening;
//using Microsoft.VisualBasic;

Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 4);
Hold h2 = new Hold("Tumle22t", 2022, "Rollinger", 700, 15);
//Console.WriteLine(h1);
//Console.WriteLine(h2);


HoldKatalog holdKatalog = new HoldKatalog();
try
{
    holdKatalog.TilføjHold(h1);
    holdKatalog.TilføjHold(h2);
}

catch (ArgumentException aex)
{
    Console.WriteLine("Fejl ved tilføjelse af hold");
}
catch (Exception ex)
{
    Console.WriteLine("Der skete en generel fejl!");
}


Console.WriteLine(holdKatalog); //udskriving vha. ToString metode


Deltager d1 = new Deltager("Poul Henriksen", "Vej 123", 2);
Deltager d2 = new Deltager("Charlotte Heegaard", "Gade 321", -1);
try
{
    h1.TilmeldDeltager(d1);
    h1.TilmeldDeltager(d2);
}
catch(FuldtHoldException fex)
{
    Console.WriteLine(fex.Message);
}
catch(ArgumentException aex)
{
    Console.WriteLine(aex.Message + " argumentexception");
}
catch(Exception exp)
{
    Console.WriteLine(exp.Message);
}
finally
{
    Console.WriteLine("Denne del udføres altid");
}

Console.WriteLine($"Prisen for 3 børn {h1.BeregnTotalPris(3)} ");
Console.WriteLine($"Prisen for 1 børn {h1.BeregnTotalPris(1)} ");
Console.WriteLine($"Prisen for 0 børn {h1.BeregnTotalPris(0)} ");
Console.WriteLine($"Prisen for -1 børn {h1.BeregnTotalPris(-1)} ");
//Console.WriteLine(d1);
//Console.WriteLine(d2);





Console.ReadLine();


