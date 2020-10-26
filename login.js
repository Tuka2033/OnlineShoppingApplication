var exp = require('express');
var app = exp();
app.listen(8100, function() {
    console.log("Server Started");
});

app.get('/', function(req, res) {
    res.sendFile(__dirname + '/login.html');
});
app.get('/loginCheck.js', function(req, res) {
    var uid = req.query.UID;
    var pwd = req.query.PWD;
    if ((uid == "object") && (pwd == "knowIt")) {
        res.sendFile(__dirname + '/index.js');
    } else {
        res.send("Login Failed");
    }
});