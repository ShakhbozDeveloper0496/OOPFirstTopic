namespace OOPFirstTopic.Classes;

class Books
{
    public string Name{ get; set; }
    public int Years{ get; set; }
     public string Author1{ get; set; }
    public string Author2{ get; set; }
    private string Author3{ get; set; }
    
    public Books()
    {
        Name = "";
        Years = 0;
        Author1 = "";
        Author2 = "";
        Author3 = "";
    }
    public Books(string bookName, int year) 
    {
        Name = bookName;
        Years = year;
        Author1 = "Robert Luis";
        Author2 = "Xurshid Do'stmatov";
        Author3 = "Chiniz Aytmatov";
    }
    public void FirstBook()
    {
        if (Name == "Merosxo'r")
        {
            System.Console.WriteLine($"kitob nomi: {Name} Chiqqan yili: {Years} Muallifi: {Author1}");
        }
        else if (Name == "Nigoh")
        {
            System.Console.WriteLine($"kitob nomi: {Name} Chiqqan yili: {Years} Muallifi: {Author2}");
        }
         else if (Name == "Somon yo'li")
        {
            System.Console.WriteLine($"kitob nomi: {Name} Chiqqan yili: {Years} Muallifi: {Author3}");
        }
        else
        {
            System.Console.WriteLine("Bunday kitob mavjud emas");
        }
    }
   
}