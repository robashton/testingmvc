namespace MyLittlePonyCrm {
  public class BronySignUp {
    public string Username { get; set; }
    public string Email { get; set ;}
    public string EmailConfirm { get; set; }
    public string Password { get; set ;}
    public string PasswordConfirm { get; set; }

    public Dictionary<string, string> Validate() {
      Dictionary<string, string> errors = new Dictionary<string, string>();
      ValidateUsername(errors);
      ValidateEmail(errors);
      ValidatePassword(errors);
    }

    private void ValidateUsername(Dictionary<string,string> errors) {
      if(String.IsNullOrEmpty(Username))
        errors["username"] = "Username must be filled in";
      else if(Username.Length < 6 || Username.Length > 12)
        errors["username"] = "Username must be between 6 and 12 characters";
      //etc
    }

    private void ValidatePassword(Dictionary<string, string> errors) {
      if(String.IsNullOrEmpty(Password))
        errors["password"] = "Password must be filled in";
      // etc
    }

    private void ValidateEmail(Dictionary<string, string> errors) {
      // etc
    }
  }
}
