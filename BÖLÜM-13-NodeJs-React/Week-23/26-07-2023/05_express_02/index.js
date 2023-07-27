const express = require("express");

const app = express();

//Gelen istekler karşılanıyor
app.use(function (request, response, next) {
    console.log('Middleware 1');
    next();
});

app.use(function (request, response, next) {
    console.log('Middleware 2');
    next();
});

app.use(function (request, response) {
    console.log('Middleware 3');
    response.end();
});

//Server ayağa kaldırılıyor
app.listen(3000, function () {
    console.log("Uygulama 3000 portunda çalışmaya başladı...");
});

