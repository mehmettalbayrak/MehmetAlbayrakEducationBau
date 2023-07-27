const express = require("express");

const app = express();

//Gelen istekler karşılanıyor
app.use("/contact", function (req, res) {
    res.send('Contact');
});

app.use("/blogs/:blogId/:userName", function (req, res) {
    res.send('Blog Details' + ' ' + req.params.blogId + ' ' + req.params.userName);
});

app.use("/blogs/:blogId", function (req, res) {
    res.send('Blog Details' + ' ' + req.params.blogId);
});

app.use("/blogs", function (req, res) {
    res.send('Blogs');
});

app.use("/", function (req, res) {
    res.send("Home Page");
});



//Server ayağa kaldırılıyor
app.listen(3000, function () {
    console.log("Uygulama 3000 portunda çalışmaya başladı...");
});

