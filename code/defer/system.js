var User = require('./user')
  , phantom = require('./phantom')

module.exports = {
  create_user: function(name) {
    return new User(name)
  }
}

phantom.start()
process.on('exit', function() {
  phantom.close()
})
