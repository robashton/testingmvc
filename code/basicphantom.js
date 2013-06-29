var system = require('system');

page.open(system.args[1], function(status){
    if (status !== "success") {
        console.log("Unable to access network");
        phantom.exit();
    } else {
        waitFor(function(){
            return page.evaluate(function(){
                return document.body.querySelector('.symbolSummary .pending') === null
            });
        }, function(){
            var exitCode = page.evaluate(function(){
                console.log('');
                console.log(document.body.querySelector('.description').innerText);
                var list = document.body.querySelectorAll('.results > #details > .specDetail.failed');
                if (list && list.length > 0) {
                  console.log('');
                  console.log(list.length + ' test(s) FAILED:');
                  for (i = 0; i < list.length; ++i) {
                      var el = list[i],
                          desc = el.querySelector('.description'),
                          msg = el.querySelector('.resultMessage.fail');
                      console.log('');
                      console.log(desc.innerText);
                      console.log(msg.innerText);
                      console.log('');
                  }
                  return 1;
                } else {
                  console.log(document.body.querySelector('.alert > .passingAlert.bar').innerText);
                  return 0;
                }
            });
            phantom.exit(exitCode);
        });
    }
});
