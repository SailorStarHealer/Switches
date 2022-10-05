//Ask the player to set a price for an item.
Console.WriteLine("Please set a price.");

//Let them enter a number, or an equation with two numbers and an operator in the middle, separated by a space on each side.

//2 + 4

string playerInput = Console.ReadLine();

//Write the resulting price.

string[] inputParts = playerInput.Split(' ');
double price;

if (inputParts.Length > 1)
{
    double firstNumber = Double.Parse(inputParts[0]);
    double secondNumber = Double.Parse(inputParts[2]);
    string operatorSymbol = inputParts[1];

    switch (operatorSymbol)
    {

        case "+":
        case "plus":
            price = firstNumber + secondNumber;
            break;

        case "-":
        case "minus":
            price = firstNumber - secondNumber;
            break;

        case "times":
        case "*":
            price = firstNumber * secondNumber;
            break;

        case "divide":
        case "/":
            price = firstNumber / secondNumber;
            break;

        default:
            Console.WriteLine("Equation not supported, this isn't a complicated calculator that can play lemmings.");
            return;
    }


}
else
{
    price = Double.Parse(inputParts[0]);
}

Console.WriteLine($"The price is {price}");