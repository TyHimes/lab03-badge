using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;

//INITIAL INPUT
System.Console.WriteLine("Enter your first and last name. ");
string? name = Convert.ToString(Console.ReadLine());
bool nullChecker = true;

//RANDOM NUMBER GENERATOR
Random rng = new Random();


//CHECKS INPUT
while (nullChecker == true)
{
    if(name == null || name == "")
    {
        System.Console.WriteLine("Please type your name again. ");
        name = Convert.ToString(Console.ReadLine());
    }
    else
    {
        name = name.ToUpper();
        break;
    }
}



//PART ONE: NAME
name = name.Trim();

int spaceFind = name.IndexOf(" ");
int lastNameLength = name.Substring(spaceFind+1).Length;

string firstName = name.Substring(0, spaceFind);
string lastName = name.Substring(spaceFind+1);

string userName = (firstName[0] + lastName).ToLower();

string initials = firstName[0] + "." + lastName[0] + ".";

//PART TWO: NUMBERS
int studentID = rng.Next(10000, 1000000);
int lockerNumber = rng.Next(1, 501);

//PART THREE: THE WALK
System.Console.Write("What is your dorm's X value?");
double dormX = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is your dorm's Y value?");
double dormY = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is your classroom's X value?");
double classX= Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is your classroom's Y value?");
double classY = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How fast do you walk in feet per second? ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(classX-dormX, 2) + Math.Pow(classY-dormY, 2)), 1);
double walkingTime = Math.Round(distance/walkingSpeed);

int walkingMinutes = Convert.ToInt16(walkingTime / 60);
int walkingSeconds = Convert.ToInt16(walkingTime % 60);

//OUTPUT
System.Console.WriteLine($"Name on badge: {name}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {initials}");
System.Console.WriteLine($"Letters in last name: {lastNameLength}");
System.Console.WriteLine($"Student ID: {studentID}");
System.Console.WriteLine($"Locker: {lockerNumber}");
System.Console.WriteLine($"Distance: {distance}");
System.Console.WriteLine($"Walk Time: {walkingMinutes} minutes and {walkingSeconds} seconds.");