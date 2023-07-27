const express = require("express");

const app = express();

//Gelen istekler karşılanıyor
app.use(function (request, response) {
    
    response.end('Hello Node Js Express');
});

//Server ayağa kaldırılıyor
app.listen(3000, function () {
    console.log("Uygulama 3000 portunda çalışmaya başladı...");
});

