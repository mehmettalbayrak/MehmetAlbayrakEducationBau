// Node js modüllerden oluşur. Bu modüllerin bağzılarını biz hazırlarız. Ba<ıları ise built-in olarak node js modülü olarak bilinir ve hazırdır. Sadece dahil etmemiz gerekir.

const http = require("http");
const server = http.createServer((request, response) => {
  if (request.url == "/") {
    response.write("<h1>Home Page</h1>");
    response.end();
  } else if (request.url == "/products") {
    response.write("<h1>Ürünler</h1>");
    response.end();
  } else if (request.url == "/categories") {
    response.write("<h1>Kategoriler</h1>");
    response.end();
  } else {
    response.write("<h1>404 Not Found</h1>");
    response.end();
  }
});
server.listen(3000);
console.log("server 3000 portunda çalışmaya başladı");
