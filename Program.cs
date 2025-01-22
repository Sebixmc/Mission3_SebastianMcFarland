// See https://aka.ms/new-console-template for more information
using Mission3_SebastianMcFarland;

List<FoodItem> foodList = new List<FoodItem>(); // this creates my foodItem

string usrAnswer = "";
while (usrAnswer != "4")
{
    Console.WriteLine("Welcome to your Food Bank Organization System.");
    Console.WriteLine("Enter the number for what you would like to accomplish.");
    Console.WriteLine("1- Add Food Item");
    Console.WriteLine("2- Delete Food Item");
    Console.WriteLine("3- Print list of Food Items");
    Console.WriteLine("4- Exit");
    Console.WriteLine("");
    Console.WriteLine("");
    usrAnswer = Console.ReadLine();

// case statement to determine which to do
    switch (usrAnswer)
    {
        case "1":
            AddFoodItem(foodList); // Add a new food item to the list
            break;
        case "2":
            DeleteFoodItem(foodList); // Implement logic to delete an item
            break;
        case "3":
            PrintFoodItems(foodList); // Implement logic to print the list
            break;
        case "4":
            Console.WriteLine("See you next time!");
            break;
        default:
            Console.WriteLine("Please enter the number for one of these options");
            break;
    }
}

void AddFoodItem(List<FoodItem> foodList)
{
    FoodItem newFood = new FoodItem();
    foodList.Add(newFood);
    Console.WriteLine("Food Item Added");
}

void PrintFoodItems(List<FoodItem> foodList)
{
    foreach (var food in foodList)
    {
        Console.WriteLine($"Name:{food.Name}, Description: {food.Description}, Quantity: {food.Quantity}, Expiration Date: {food.ExpirationDate}");
    }
}

void DeleteFoodItem(List<FoodItem> foodList)
{
    Console.WriteLine("Enter the name of the food item to delete");
    string nameToDelete = Console.ReadLine();
    var foodToDelete = foodList.Find(x => x.Name.ToLower() == nameToDelete.ToLower());
    
    if (foodToDelete != null)
    {
        foodList.Remove(foodToDelete);
        Console.WriteLine($"Food item '{nameToDelete}' deleted.");
    }
    else
    {
        Console.WriteLine("Food item not found.");
    }
}







