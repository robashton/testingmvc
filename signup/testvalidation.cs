namespace MyLittlePonyCrm.Tests {

  [TestFixture]
  public class SignupValidation {
    BronySignUp model = new BronySignUp();

    [Setup]
    public void SetupValidModel() {
      model.Username = "Hairy Brony";
      model.Email = "hairybrony@clopclop.com";
      model.EmailConfirm = "hairybrony@clopclop.com";
      model.Password = "pinkiepie";
      model.PasswordConfirm = "pinkiepie";
    }

    [Test]
    public void Valid() {
      model.Validate().ShouldContainZeroErrors();
    }

    [Test]
    public void EmptyUsername() {
      model.Username = "";
      model.Validate().ShouldContainOneError("username");
    }

    [Test]
    public void ShortUsername() {
      model.Username = "bob";
      model.Validate().ShouldContainOneError("username");
    }

    [Test]
    public void LongUsername() {
      model.Username = "pinkiepieisthebestpony";
      model.Validate().ShouldContainOneError("username");
    }

    [Test]
    public void NoPassword() {
      model.Password = "";
      model.Validate().ShouldContainOneError("password");
    }

    /// etc

  }
}
