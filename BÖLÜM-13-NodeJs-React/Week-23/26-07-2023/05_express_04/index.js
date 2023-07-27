const express = require("express");
const path = require('path');
const app = express();

// https://localhost:3000/node_modules adresine erişmem gerektiğinde ben "libs" diyeceğim.
app.use('/libs', express.static(path.join(__dirname, "node_modules")));
app.use('/static', express.static(path.join(__dirname, "public")));
/*
Üstteki her iki satırda yazdığımız kodların alternatifi:
app.use('/libs',express.static("node_modules"));
*/
app.use("/blogs/:blogId", function (req, res) {
    res.sendFile(path.join(__dirname, "views", "blogdetails.html"));
});

app.use("/blogs", function (req, res) {
    res.sendFile(path.join(__dirname, "views", "blogs.html"));
});

app.use("/", function (req, res) {
    res.sendFile(path.join(__dirname, "views", "index.html"));
});




app.listen(3000, function () {
    console.log("Uygulama 3000 portunda çalışmaya başladı...");
});

