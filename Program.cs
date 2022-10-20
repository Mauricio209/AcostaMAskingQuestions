//mauricio acosta
//10-18-22
//Git Challenge asking questions

string replay = "yes";
while(replay == "yes")
{
Console.Clear();
Console.WriteLine("What is your name?");

string myName = Console.ReadLine();

Console.WriteLine("Good Afternoon " + myName);

Console.WriteLine("How have you been! " + myName);

string myAge = Console.ReadLine();

Console.WriteLine("You are " + myName + " and you've been " + myAge);

Console.WriteLine("To replay type yes");
replay = Console.ReadLine();

}