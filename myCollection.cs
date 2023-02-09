using System;

class myCollection {
  public static void Main (string[] args) {
    Item[] collection = new Item[5];
    
    for(int i = 0; i<5; i++){
      Console.WriteLine("Please enter B for Book or P for Periodical");
      string choice = Console.ReadLine();
      if(choice.Equals("B")){
        string title, author;
        int isbn;
        
        Console.WriteLine("Please enter the name of the Book");
        title = Console.ReadLine();

        Console.WriteLine("Please enter the author of the Book");
        author = Console.ReadLine();

        Console.WriteLine("Please enter the ISBN of the Book");
        isbn = Convert.ToInt32(Console.ReadLine());

        collection[i] = new Book(title, isbn, author);
      }

      if(choice.Equals("P")){
        string title;
        int issue;
        
        Console.WriteLine("Please enter the name of the Periodical");
        title = Console.ReadLine();

        Console.WriteLine("Please enter the Issue of the Periodical");
        issue = Convert.ToInt32(Console.ReadLine());

        collection[i] = new Periodical(title, issue);
      }
    }

    foreach(Item item in collection){
      Console.WriteLine(item.getListing()+"\n");
    }
  }
}//end of main