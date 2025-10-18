// TrainingExercise by Daniil

Console.WriteLine("Welcome to the Accumulator!");
Console.WriteLine("Enter a negative number to quit:");

int newNumber = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(newNumber >= 0)
{
    if (newNumber >= 0)
    {
        sum += newNumber;
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Enter a negative number to quit:");
        newNumber = Convert.ToInt32(Console.ReadLine());
    }
    
}
    Console.WriteLine("Final Sum: " + sum);
    Console.WriteLine("Goodbye!");