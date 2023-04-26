using RecipeApplication;

class Recipe
{
    private Ingredient[] ingredients;
    private Step[] steps;

    public Recipe()
    {
        Console.Write("Enter the number of ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());

        ingredients = new Ingredient[numIngredients];

        for (int v = 0; v < numIngredients; v++)
        {
            Console.Write($"Enter the name of ingredient {v + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the quantity of {name}: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.Write($"Enter the unit of measurement for {name}: ");
            string unit = Console.ReadLine();

            ingredients[v] = new Ingredient(name, quantity, unit);
        }

        Console.Write("Enter the number of steps: ");
        int numSteps = int.Parse(Console.ReadLine());

        steps = new Step[numSteps];

        for (int v = 0; v < numSteps; v++)
        {
            Console.Write($"Enter the description for step {v + 1}: ");
            string description = Console.ReadLine();

            steps[v] = new Step(description);
        }
    }

    public void Display()
    {
        Console.WriteLine("Ingredients:");

        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
        }

        Console.WriteLine("Steps:");

        for (int v = 0; v < steps.Length; v++)
        {
            Console.WriteLine($"{v + 1}. {steps[v].Description}");
        }
    }

    public void Scale(double factor)
    {
        foreach (Ingredient ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    public void Reset()
    {
        foreach (Ingredient ingredient in ingredients)
        {
            ingredient.Quantity /= 2;
        }
    }

    public void Clear()
    {
        Array.Clear(ingredients, 0, ingredients.Length);
        Array.Clear(steps, 0, steps.Length);
    }
}