using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

System.Console.WriteLine("Enter your first and last name. ");
string? name = Convert.ToString(Console.ReadLine());
bool nullChecker = true;

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


name = name.Trim();

int spaceFind = name.IndexOf(" ");
int lastNameLength = name.Substring(spaceFind+1).Length;

string firstName = name.Substring(0, spaceFind);
string lastName = name.Substring(spaceFind+1);

string userName = (firstName[0] + lastName).ToLower();

string initials = firstName[0] + "." + lastName[0] + ".";



System.Console.WriteLine($"Name on badge: {name}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {initials}");
System.Console.WriteLine($"Letters in last name: {lastNameLength}");