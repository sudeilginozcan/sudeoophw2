
//derece dönüşümü
Console.WriteLine("Temperature Conversion");
Console.Write("Enter temperature in Celsius: ");
double celsius = double.Parse(Console.ReadLine());

double kelvin = celsius + 273.15;
double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;

Console.WriteLine($"Kelvin: {kelvin:F2} K");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F\n");

//sınav not ortalaması
Console.WriteLine("Exam Grades and Average");
Console.Write("Enter grade 1: ");
int grade1 = int.Parse(Console.ReadLine());

Console.Write("Enter grade 2: ");
int grade2 = int.Parse(Console.ReadLine());

Console.Write("Enter grade 3: ");
int grade3 = int.Parse(Console.ReadLine());

int sum = grade1 + grade2 + grade3;
double average = (double)sum / 3;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");

bool isPassing = average >= 60;
Console.WriteLine($"Average >= 60: {isPassing}");

if (average >= 60)
{
    Console.WriteLine("Status: Passed");
}

if (average < 60)
{
    Console.WriteLine("Status: Failed");
}
Console.WriteLine();

// basamak ayırma
Console.WriteLine("Digits of a 3-Digit");
Console.Write("Enter a 3-digit number: ");
int number = int.Parse(Console.ReadLine());

int hundreds = number / 100;
int tens = (number / 10) % 10;
int ones = number % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {ones}");
