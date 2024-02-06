using System.Collections;
class Program
{
    private static void Main(string[] args)
    {
        //Program adds to the collection cities:then sorts them alphabetically.
        var citiesList = new ArrayList();

        citiesList.Add("Gdańsk");
        citiesList.Add("Warszawa");
        citiesList.Add("Katowice");
        citiesList.Add("Poznań");
        citiesList.Add("Kraków");
        citiesList.Add("Rzeszów");

        citiesList.Sort();
        Console.WriteLine("Cities sorted alphabetically are:");
        foreach (var city in citiesList) 
        {
            Console.WriteLine(city);
        }
        Console.ReadLine();
    }
}



