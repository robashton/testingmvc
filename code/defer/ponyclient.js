var wd = require('wd-sync')
  , capyshims = require('capyshims')

module.exports = function(name) {
  capyshims.copyMethodsInto(this)

  var self = this
    , browser = wd.init()

  self.should_be_on = function(route) {
    browser.path.should.equal(route)
  }

  self.sign_in = function(cb) {
    self.click('Sign In')
    self.fill('Username', name)
    self.fill('Password', 'password')
    self.submit(cb)
  }
}
