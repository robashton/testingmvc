namespace MyLittlePonyCrm {

  public class Stable : IHousePonies {
    private Dictionary<string, Pony> ponies = new Dictionary<string, Pony>();

    public void House(Pony pony) {
      ponies[pony.Name] = pony;
    }
  }

}
