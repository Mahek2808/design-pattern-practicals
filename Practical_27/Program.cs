
// C# 10 We don't need to use main Method
Console.WriteLine("Hello, User!");
Console.WriteLine("--------------------------");
Console.WriteLine("Enter First Number:");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter Second Number:");
float num2 = float.Parse(Console.ReadLine());

float sum = num1 + num2;
float sub = num1 - num2;
float mul = num1 * num2;
float div = num1 / num2;

Console.WriteLine("Sum of {0} and {1} is: {2}", num1, num2, sum);
Console.WriteLine("Subtractionof {0} and {1} is: {2}", num1, num2, sub);
Console.WriteLine("Multiplicationof {0} and {1} is: {2}", num1, num2, mul);
Console.WriteLine("Divisionof {0} and {1} is: {2}", num1, num2, div);

// used text.jason globally in global.cs file
Console.WriteLine("--------------------------");
var names = new[] { "Janvi", "Vidhi", "Mahek", "Vrunda" };
var serialized = JsonSerializer.Serialize(names);
Console.WriteLine(serialized);

//Lambdaexpression c# 9
//Func<string> helloWorld = () => "Hello world";
//Lambdaexpression c# 10
Console.WriteLine("--------------------------");
var helloWorld = () => "Hello World";
Console.WriteLine(helloWorld());

//Lambdaexpression c# 9
//Func<string?> text = () => null;
//Lambdaexpression c# 10
Console.WriteLine("--------------------------");
var text = string? () => null;
Console.WriteLine(text());


