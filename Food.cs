namespace Mission3_SebastianMcFarland;

public class FoodItem
{
    //fields to get ready
    public Array FoodItems;
    public string Name = "";
    public string Description = "";
    public int Quantity = 0;
    public string ExpirationDate = "";

    public FoodItem()
    {
        Console.WriteLine("What is the name of the food? ");
        Name = Console.ReadLine();
        Console.WriteLine("What is the description of the food? ");
        Description = Console.ReadLine();
        Console.WriteLine("What is the quantity of the food? ");
        Description = Console.ReadLine();
        Console.WriteLine("What is the expiration date of the food? ");
        ExpirationDate = Console.ReadLine();
    }

}