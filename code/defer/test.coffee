system = require 'system'

Scenario "Creating a new pony", ->
  bob = system.create_user 'bob'

  Given "Bob has signed into the pony CRM", (done) ->
    bob.sign_in done

  When "he fills in Rainbow Dashes information", (done) ->
    bob.fill 'Name', 'Rainbow Dash'
    bob.fill 'Age', 1337
    bob.fill 'TrampStamp', 'Lightning'
    bob.fill 'Catchphrase', 'I could clear this sky in 10 seconds flat'
    bob.submit done

  Then "he should be redirected to rainbow dashes page", ->
    bob.should_be_on pony_route_for 'Rainbow Dash'

  Then "he should see rainbow dash's name", ->
    bob.should_see 'Rainbow Dash'
