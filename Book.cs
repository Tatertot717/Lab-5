class Book : Item{
  private int isbn_number;
  private string author;

  public string Author { get => author; set => author = value; }
  public int Isbn_number { get => isbn_number; set => isbn_number = value; }
  
  public Book(){
    setTitle("");
    isbn_number = 0;
    this.author = "";
  }

  public Book(string title, int isbn_number, string author){
    setTitle(title);
    this.isbn_number = isbn_number;
    this.author = author;
  }

  public override string getListing(){
    return(("Book Name - "+getTitle()+"\nAuthor - "+author+"\nISBN # - "+isbn_number));
  }
  
}