/*
* Name: Elizabeth Loveless
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 14, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/

const int SlicesPerPizza = 8;
const double TaxRate=0.18;

// Part 1: The Trip
Console.Write("Round Trip Miles: ");
double miles=Convert.ToDouble(Console.ReadLine());
Console.Write("Miles Per Gallon: ");
double milesPerGallon=Convert.ToDouble(Console.ReadLine());
Console.Write("Price Per Gallon: ");
double pricePerGallon=Convert.ToDouble(Console.ReadLine());
Console.Write("How Many Pizzas: ");
int pizzas = Convert.ToInt32(Console.ReadLine());
Console.Write ("Price Per Pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double fuelCost = FuelCost(miles, milesPerGallon, pricePerGallon);
double pizzaCost = pizzas * pricePerPizza;
double tripTotal = fuelCost + pizzaCost;

Console.WriteLine("===Part 1: The Trip===");
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine();


//Part 2: The Group
string[] names = {"Ada", "Grace", "Alan", "Katherine"};
double [] hoursWorked = {22, 15, 30, 18};
double [] hourlyRate = {13.50, 16.00, 11.20, 14.80};

double totalSlices = pizzas * SlicesPerPizza;
double slicesEach = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;

Console.WriteLine("===Part 2: The Group===");
Console.WriteLine ("People going: " + names.Length);
Console.WriteLine("Slices each: " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine();

//Part 3: Who Works How Long
double totalHours = 0;
double totalTakeHome = 0;
double longest = 0;

Console.WriteLine("===Part 3: Who Works How Long ===");

for(int i = 0; i < names.Length; i++)
{


    double takeHome = TakeHomePay(hoursWorked[i], hourlyRate[i], TaxRate);
    double takeHomePerHour = takeHome / hoursWorked[i];
    double hoursNeeded = HoursToCover(costPerPerson, takeHomePerHour);

    totalHours += hoursWorked[i];
    totalTakeHome += takeHome;
    longest = Math.Max (longest, hoursNeeded);

    Console.WriteLine(names[i]+ ": takes home " + takeHome.ToString("C")+ " for " + hoursWorked[i].ToString("F0") + " hours, "
    + takeHomePerHour.ToString("C") + " per hour, must work " + hoursNeeded.ToString ("F2") + " hours ");
}

Console.WriteLine();
Console.WriteLine("Total Hours Worked:" + totalHours.ToString("F0"));
Console.WriteLine("Total Take Home Pay:" + totalTakeHome.ToString("C"));
Console.WriteLine("longest Anyone Must Work:" + longest.ToString("F2"));

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)

{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
static double TakeHomePay (double hours, double hourlyRate, double taxRate)
{
    double pay = hours * hourlyRate;
    double tax = pay * TaxRate;
    return pay - tax;
}
static double HoursToCover(double amountOwed, double takeHomePerHour)

{
    return amountOwed / takeHomePerHour; 
}
