# Outside-in Testing ASP.NET MVC 

## Agenda

### Who am I?

 - I am @robashton
 - I write code
 - My favourite is the JavaScripts
 - I work in Rails, I do not really like it
 - I do not like it
 - I build ASP.NET MVC for pizza </joke>
 - I have some opinions on building software

### Who is this session for?

 - You use ASP.NET MVC
 - You want to test your application
 - You want your project to succeed

### What am I am trying to help with? (Let me tell you a story)

 - "We tried doing TDD because it is the right thing to do"
 - "You should test trivial code"
 - "You should inject all your dependencies"
 - "You should avoid all the coupling"

 - "We wrote tests for every line of code, because we should even test trivial code"
  - "We ended up with too many tests"
  - "We ended up spending most of our time fixing tests" 
  - "Our test suite made our build really slow"
  - "We deleted the test suite because it was slowing us down"

### So you know where I am coming from

- I think that...

 - Real TDD is too difficult to inflict on most dev teams
 - The cost of trying to apply TDD in most dev teams is too high
 - It is better to focus on reaping real returns, than to listen to some guy off the internet or at a conference (sorry)
 - Practise TDD outside of work, but do not inflict it on the vast majority of your codebase
 - TDD itself is pretty good for working on the unknown or small logical problems
 - TDD itself has a lot of value when used correctly by experts or TDD consultants

- Assumptions
 - You do not have the liberty to adopt a spike and stabilise approach
 - You are not working at a start-up
 - You are working at "standard enterprise company 030035B" and want to do it better

### 

BOOM EXPLOSION

So, you are starting a new project.

- We are using ASP.NET MVC (this is a massive constraint)
- Database as an implementation detail
- Slow things as an implementation detail
- Everything else is fair game
- Let us begin

### What does this project do?

- It is the latest in the line of our company's own line of unique blue-sky PRM (Pony Relationship Management) systems

Write a test.

    Scenario "Visiting as a guest", ->
      Given "Bob is looking at kittens on the internet", (done) ->
        bob.look_at_kittens(done)
      When "Bob decides to look at our funky CRM instead", (done) ->
        bob.visit_crm_home(done)
      Then "Bob should see a sign in button", ->
        bob.can_see('#sign-in').should.equal(true)
      And "Bob should see our web title", ->
        bob.can_see('Funky CRM').should.equal(true)

# What have I done
- Made a statement of intent
- "I am going to write tests around my system that aren't a total ballache to run"

### What have I not done?

- I have not decided to use my favourite Container
- I have not decided to use my favourite ORM
- I have not decided to use my favourite mocking framework
- Etc

### My preferred testing tools

- PhantomJS
- WebDriver
- Coypru (lies, actually I write my UI tests in node, but whatevs!)

Why? Because they're fast.

## What do we need to do to make this work?

- We could do with a working web server
- We need a static web page served by that server

Let's use XSP2 and make that happen

- process.start
- run tests
- process.exit

Success.

# Putting the ponies in a stable (persistence)

# Giving our ponies houses (relationships)

# Uploading pony pictures (external and slow dependencies)

# But "rob, what about shared state between tests"

*Either*

- Write tests that are isolated by their very nature alone
- Write an endpoint that you can ping to clear the memory
- *for now*, it's too slow to tear up/down ASP.NET MVC - this will change

# Anyway the feature is finished, now what?

- Where to store the ponies?
- Where to put the files?

Let's re-use our tests on the live system...


# Great, that's how we build stuff, how about some common ASP.NET MVC testing problems

- Trying to write unit tests for infrastructure concerns
 - Filters
 - Validators
 - Binders

- Common issues with this

  var context = new Mock<HttpContextBase>()
  var server = new Mock<HttpContextServerBase>()
  var controllerContext = new Mock<ControllerContextBase>()

  context.Get(x=>x.Server, server)
  controllerContext.Get(x=>x.Context, context)

  // etc

- No, using an auto-mocking thing to do

  var controllerContext = new CrazyAutoMock<ControllerContextBase>()

Is not a solution

- If you have complicated logic (think resource authorization), then pull it out and write it independently of ASP.NET MVC and consume it
- If it's not complicated, then move on and make sure your end-to-end tests cover it


There are two reasons to drop down to a lower level test
- They're faster
- You need more feedback

The first one is wrong, make your outside tests faster - inverting the testing pyramid is a false goal.
