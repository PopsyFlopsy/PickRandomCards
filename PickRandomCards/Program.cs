using PickRandomCards;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter number of cards to pick: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Please enter valid number.");
        }
    }
}