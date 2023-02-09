abstract class Item{
  private string title;

  public Item(){
    title = "";
  }
  public Item(string title){
    this.title = title;
  }

  public string getTitle(){
    return(title);
  }

  public void setTitle(string title){
    this.title = title;
  }

  public override string ToString(){
    return(title);
  }

  public abstract string getListing();
}
