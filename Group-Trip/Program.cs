/*
* Name: Elizabeth Loveless
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 14, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/



const int SlicesPerPizza = 8;
const double TaxRate=.18;

// Part 1: The Trip
Console.Write("Round Trip Miles: ");
double RoundTripMiles=Convert.ToDouble(Console.ReadLine());
Console.Write("Miles Per Gallon: ");
double MilesPerGallon=Convert.ToDouble(Console.ReadLine());
Console.Write("Price Per Gallon: ");
double PricePerGallon=Convert.ToDouble(Console.ReadLine());
Console.Write("How Many Pizzas: ");
int Pizzas = Convert.ToInt32(Console.ReadLine());
Console.Write ("Price Per Pizza: ");
double PricePerPizza = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("===Part 1: The Trip===");
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));

double fuelCost = FuelCost (MilesPerGallon, MilesPerGallon, PricePerGallon);
double pizzaCost = Pizzas * PricePerPizza;
double tripTotal = fuelCost + pizzaCost;

//Part 2: The Group
string[] names = {"Ada", "Grace", "Alan", "Katherine"};
double [] hoursWorked = {22, 15, 30, 18};
double [] hourlyRate = {13.50, 16.00, 11.20, 14.80};

double totalSlices = Pizzas * SlicesPerPizza;
double sliceEach = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;

Console.WriteLine("===Part 2: The Group===");
Console.WriteLine ("People going: " + names.Length);
Console.WriteLine("Slices each: " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine();

//Part 3: Who Works How Long 
double totalHoursWorked = 0;
double totalTakeHomePay = 0;
double longestHoursWorked = 0;

Console.WriteLine("===Part 3: Who Works How Long ===");

for(int i = 0; i < names.Length; i++)
{
    
}
