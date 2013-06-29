namespace MyLittlePonyCrm {
  public class NewPonyInput {
    [Required]
    public string Name { get; set; }
    [Required]
    public string TrampStamp { get; set; }
    [Required]
    public string Age { get; set; }
    [Required]
    public string Catchphrase { get; set; }

    public Pony ToPony() {
      return new Pony(Name, TrampStamp, Age, Catchphrase);
    }

  }
}

