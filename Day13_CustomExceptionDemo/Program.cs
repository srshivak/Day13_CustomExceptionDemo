// See https://aka.ms/new-console-template for more information
using Day13_CustomExceptionDemo;

/*
int age = 0;
try
{
    age = 0;
    Console.WriteLine("Enter Age: ");
    age = Convert.ToInt32(Console.ReadLine());
    if (age < 18 || age > 80)
    {
        age = 0;
        throw new InvalidAgeException("Invalid age, Age Should be between 18 - 80 Only");
    }
}
catch(InvalidAgeException ie)
{
    Console.WriteLine(ie.Message);
}
finally
{
    Console.WriteLine($"Age = {age}");
}
*/

UsingException ue = new UsingException();
ue.CreateFile();