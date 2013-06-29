namespace MyLittlePonyCrm {
  public class Pony {
    readonly string name;
    readonly string trampstamp;
    readonly int age;
    readonly string catchphrase;
    
    public Pony(string Name, string trampstamp, int age, string catchphrase) {
      this.name = Name;
      this.trampstamp = trampstamp;
      this.age = age;
      this.catchphrase = catchphrase;
    }

    public void Speak() {
      Console.WriteLine(this.catchphrase);
    }

    public void Gallop() {
    }

    public void Prance() {
    }

  }
}
