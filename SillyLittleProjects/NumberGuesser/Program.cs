// See https://aka.ms/new-console-template for more information

// Create a number guessing game
// The user will get a prompt from which numbers he can choose (i.e.: number between 0 and 100)
// A number will get randomly chosen
// The user has to input a number he thinks might be correct
// If the number is lower than the input, give the user a message
// If the number is higher than the input, give the user a message
// If the number is the input, give the user a message and ask for a retry
// If the user types in a number out of range, provide the user a message and catch the crash

Console.Title = "NumberGuesser.Console | by RayuDW";

int randomNumber = GenerateRandomNumber();
bool hasGuessedNumber = false;

while (!hasGuessedNumber)
{
    string numberGuess = AskForNumberInput();
    var conversionResult = short.TryParse(numberGuess, out short number);
    Console.Clear();

    if (conversionResult)
    {
        if (number <= 100)
        {
            if (Math.Abs(number - randomNumber) <= 5)
            {
                Console.WriteLine("You're close!!");
            }

            if (number > randomNumber)
            {
                Console.WriteLine("Try a lower number!");
            }
                    
            else if (number < randomNumber)
            {
                Console.WriteLine("Try a higher number!");
            }

            else
            {
                Console.WriteLine("That's the number!!");
                hasGuessedNumber = true;
                Console.WriteLine("> Press any key to exit!");
            }
        }
    }

    else
    {
        Console.WriteLine($"ERROR: Could not convert '{numberGuess}'!");
    }
}

Console.ReadKey();
Environment.Exit(0);
            
int GenerateRandomNumber()
{
    Random rng = new Random();
    int randomNumber = rng.Next(0, 101);

    return randomNumber;
}

string AskForNumberInput()
{
    Console.WriteLine("Enter a number between 0 and 100:");
    Console.Write("> ");

    string numberGuess = Console.ReadLine();
    return numberGuess;
}