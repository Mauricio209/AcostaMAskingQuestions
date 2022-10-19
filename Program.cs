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

Console.WriteLine("How old are you! " + myName);

string myAge = Console.ReadLine();

Console.WriteLine("You are " + myName + " and your age is " + myAge);

Console.WriteLine("To replay type yes");
replay = Console.ReadLine();

}