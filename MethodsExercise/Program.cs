//Exercise 1 - Nick Carlson
using MethodsExercise;

Console.WriteLine("Exercise 1:");

// Asks the user for their name.

Console.WriteLine("Hello User! What is your name? ");
var name = Console.ReadLine();

//Asks the user for their favorite color.

Console.WriteLine($"Hey {name}, nice to meet you! What is your favorite color? ");
var color = Console.ReadLine();

//Asks the user for their favorite animal.

Console.WriteLine($"The color {color} is awesome! What is your favorite animal? ");
var animal = Console.ReadLine();

// Asks the user for their favorite band.

Console.WriteLine($"Woah! That animal the {animal} really rocks!");
Console.WriteLine("Speaking of things that rock?, what is your favorite band? ");
var band = Console.ReadLine();

Console.Write($"Well {name}, it was great getting to meet you! I hope you find a great sale on a {color} shirt, and you get to play with a {animal} soon! " +
    $"Also great taste in music, {band} is a great band, okay talk to you soon!");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

//Exercise 2
// Math Method Stuff
Console.WriteLine("Exercise 2:");

int add = Exercise_2.Add(2, 2);
int sub = Exercise_2.Subtract(2, 2);
int mul = Exercise_2.Multiply(2, 2);
int div = Exercise_2.Divide(2, 2);
int mod = Exercise_2.Modulus(2, 2);

Console.WriteLine($"2 + 2 when added gives you the sum of {add}; when subtracted {sub}; when multiplyed {mul}; when divided {div}; and finally with a modulus {mod}!");
Console.WriteLine();

// Params Stuff

Console.WriteLine("Using a Params list!");
int[] myIntArray = { 1, 2, 3 };

UsingParams.Params(myIntArray);
