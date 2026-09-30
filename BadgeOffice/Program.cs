/*
* Name: Tyler Himes
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;

//RANDOM NUMBER GENERATOR
Random rng = new Random();

//---------- PART ONE: THE NAME ----------//

// PART ONE: INITIAL INPUT
System.Console.Write("Enter your first and last name. ");
string? name = Convert.ToString(Console.ReadLine());
const bool nullChecker = true;

//CHECK INITIAL INPUT
while (nullChecker == true)
{
    if(name == null || name == "")
    {
        System.Console.Write("Please type your name again. ");
        name = Convert.ToString(Console.ReadLine());
    }
    else
    {
        break;
    }
}

//PART ONE: INPUT PROCESSING
name = name.Trim();
name = name.ToUpper();

int spaceFind = name.IndexOf(" ");
int lastNameLength = name.Substring(spaceFind+1).Length;

string firstName = name.Substring(0, spaceFind);
string lastName = name.Substring(spaceFind+1);

string userName = (firstName[0]+lastName).ToLower();

string initials = firstName[0] + "." + lastName[0] + ".";

//---------- PART TWO: THE NUMBERS ----------//
int studentID = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);



//---------- PART THREE: THE WALK ----------//

//PART THREE INPUT
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

//PART THREE CALCULATIONS
double distance = Math.Round(Math.Sqrt(Math.Pow(classX-dormX, 2) + Math.Pow(classY-dormY, 2)), 1);
double walkingTime = Math.Round(distance/walkingSpeed);

int walkingMinutes = Convert.ToInt16(walkingTime / 60);
int walkingSeconds = Convert.ToInt16(walkingTime % 60);



//---------- PART FOUR: ETSU STUDENT BADGE ----------//

//PART FOUR CALCULATION: STUDENT ID WITH CHECK DIGIT
int checkDigit = studentID % 9;
string checkStudentID = studentID + "-" + checkDigit;


//---------- ENTIRE OUTPUT BLOCK ----------//

// PART ONE OUTPUT:
System.Console.WriteLine($"Name on badge: {name}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {initials}");
System.Console.WriteLine($"Letters in last name: {lastNameLength}\n");

// PART TWO OUTPUT:
System.Console.WriteLine($"Student ID: {studentID}");
System.Console.WriteLine($"Locker: {lockerNumber}\n");

//PART THREE OUTPUT:
System.Console.WriteLine($"Distance: {distance}");
System.Console.WriteLine($"Walk Time: {walkingMinutes} minutes and {walkingSeconds} seconds. \n");

//PART FOUR OUTPUT:
System.Console.WriteLine("==================================\n        ETSU STUDENT BADGE        \n==================================");
System.Console.WriteLine("NAME".PadRight(10) + $"{name}");
System.Console.WriteLine("USERNAME".PadRight(10) + $"{userName}");
System.Console.WriteLine("ID".PadRight(10) +  $"{checkStudentID}");
System.Console.WriteLine("LOCKER".PadRight(10) +  $"{lockerNumber}");
System.Console.WriteLine("WALK".PadRight(10) + $"{walkingMinutes} min {walkingSeconds} sec");
System.Console.WriteLine("==================================");