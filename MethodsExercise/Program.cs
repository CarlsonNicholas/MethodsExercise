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

