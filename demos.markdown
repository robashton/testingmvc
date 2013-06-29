- Show cucumber tests from shopa.com
- Show Capybara tests in Ruby
- Show Coypu tests in C#
- Show PhantomJS raw examples
- Show running WebDriver/Phantom/Coffee tests
- 
Have all the above all ready and open

- Example: Defer the decisions
   - Write a very simple controller action
   - Write a very simple coffeescript test about storing ponies
   - Speak to an interface IHousePonies
   - Speak to a class "InMemoryStable"
   - Let's not talk about using a database until we have to

- Example: Let's use RavenDB for the same task
  - Write a very simple controller action
  - Write a very simple coffeescript test about storing ponies
  - Don't bother with an interface, load that pony
  - We have in-memory mode for speed

Either of these is fine, iteration speed is what is important
The first is probably a better bet if you're going to end up using SQL

- Dropping down - testing validation

  - You might have a feature test for a workflow step
  - But it's going to be faster to write tests for the validation
  - Must have an e-mail address
  - Must be a valid e-mail address
  - If a password is specified, the confirmation must batch
  - No password being specified means no errors

  - The key is the variants, how many do you have?

- Testing Action Filters

  - Focus on the logic you need
  - Ignore implementation details
  - Don't consume ASP.NET code until you have to
  - Invert the dependencies to ASP.NET


