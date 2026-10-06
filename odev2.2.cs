Console.Write("Enter the first exam: ");
double firstExam = double.Parse(Console.ReadLine()!);

Console.Write("Enter the second exam: ");
double secondExam = double.Parse(Console.ReadLine()!);

Console.Write("Enter the third exam: ");
double thirdExam = double.Parse(Console.ReadLine()!);

double sum= firstExam+secondExam+thirdExam;

double average=sum/3;
Console.WriteLine($"Sum is: {sum}");

if (average >=60) Console.WriteLine($"Average is: {average:f2}");