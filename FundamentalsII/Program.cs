//1.) Three Basic Arrays
int[] IntArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] StrArr = {"Tim", "Martin", "Nikki", "Sara"};
bool[] BoolArr = new bool[10];
for (int i = 0; i < BoolArr.Length; i++)
{
    if (i % 2 == 0)
    {
        BoolArr[i] = true;
    }
    else
    {
        BoolArr[i] = false;
    }
    Console.WriteLine(BoolArr[i]);
}

//2.) List of Flavors
List<string> flavors = new List<string>() {"Vanilla Bean", "Rocky Road", "Cookies & Cream", "Matcha Green Tea", "Dulce De Leche"};
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);

//3.) User Dictionary
Dictionary<string, string> user = new Dictionary<string, string>();
Random rand = new Random();

foreach(string name in StrArr)
{
    int randomIdx = rand.Next(flavors.Count);
    string flavor = flavors[randomIdx];
    user.Add(name, flavor);
}

// Loop through the dictionary and print out each user's name and their associated ice cream flavor
foreach(KeyValuePair<string, string> entry in user)
{
    Console.WriteLine($"{entry.Key}'s favorite flavor is {entry.Value}");
}

