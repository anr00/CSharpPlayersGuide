Write("Welcome to the soup maker");
(Type type, Ingredient ingredient, Seasoning seasoning) soup = (GetType(), GetIngredient(), GetSeasoning());
Write("Your soup: ");
Console.WriteLine($"Type: {soup.type}");
Console.WriteLine($"Ingredient: {soup.ingredient}");
Console.WriteLine($"Seasoning: {soup.seasoning}");
                
void Write(string text)
{
    Console.WriteLine(text);
}

Type GetType()
{
    Write("Please choose one of them: soup, stew, gumbo");
    string anwser = Console.ReadLine();
    return anwser switch
    {
        "soup" => Type.soup,
        "stew" => Type.stew,
        "gumbo" => Type.gumbo
    };
}

Ingredient GetIngredient()
{
    Write("Please choose one of them: mushrooms, chicken, carrots, potatoes");
    string anwser = Console.ReadLine();
    return anwser switch
    {
        "mushrooms" => Ingredient.mushrooms,
        "chicken" => Ingredient.chicken,
        "carrots" => Ingredient.carrots,
        "potatoes" => Ingredient.potatoes
    };     
}

Seasoning GetSeasoning()
{
    Write("Please choose one of them: spicy, salty, sweet");
    string anwser = Console.ReadLine();
    return anwser switch
    {
        "spicy" => Seasoning.spicy,
        "salty" => Seasoning.salty,
        "sweet" => Seasoning.sweet
    };
}

enum Type {soup, stew, gumbo};
enum Ingredient {mushrooms, chicken, carrots, potatoes}
enum Seasoning {spicy, salty, sweet}