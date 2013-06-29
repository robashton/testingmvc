[Binding]
public class BasicCoypuSteps
{
    private readonly BrowserSession _browser;

    public BasicCoypuSteps(BrowserSession browser)
    {
        _browser = browser;
    }

    [When("Visiting the home page")]
    public void VisitHomePage()
    {
        _browser.Visit("/");
    }

    [When("Filling out his credentials")]
    public void VisitHomePage()
    {
        _browser.Fill("Username", "Bob");
        _browser.Fill("Password", "Password");
    }
}
