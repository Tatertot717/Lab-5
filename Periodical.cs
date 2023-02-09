class Periodical : Item{
  private int issueNum {get; set;} //issueNum setter/getter
  
  public Periodical(string title, int issueNum){
    setTitle(title);
    this.issueNum = issueNum;
  }

  public Periodical(){
    setTitle("");
    this.issueNum = 0;
  }

  public override string getListing(){
    return(("Periodical Title - "+getTitle()+"\nIssue - "+issueNum));
  }
}