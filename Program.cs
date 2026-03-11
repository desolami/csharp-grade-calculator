Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

double num = 0;
Console.WriteLine("Enter your score: ");
while (!double.TryParse(Console.ReadLine(), out num))
{

    Console.WriteLine("Invalid Score. Please enter a number");
}

string grade = "";
if (num >= 70 && num <= 100)
{

    grade = "A";
}
else if (num >= 60 && num <= 69)
{

    grade = "B";
}
else if (num >= 50 && num <= 59)
{

    grade = "C";
}
else if (num >= 45 && num <= 49)
{
    grade = "D";
}

else if (num >= 40 && num <= 44)
{
    grade = "E";
}

else if (num <= 40)
{
    grade = "F";
}

Console.WriteLine($"Your score : {num}");
Console.WriteLine($"Your grade : {grade}");

string answer = "yes";

while (answer == "yes")
{
  

    Console.WriteLine("Do you want to check another score? (yes/no)");
    answer = Console.ReadLine();
}

Console.WriteLine("Goodbye!");





