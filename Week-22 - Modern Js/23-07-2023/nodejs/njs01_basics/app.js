// Node js modüllerden oluşur. Bu modüllerin bağzılarını biz hazırlarız. Ba<ıları ise built-in olarak node js modülü olarak bilinir ve hazırdır. Sadece dahil etmemiz gerekir.

const http = require("http");
const server = http.createServer((request, response) => {
  response.write("<h1>Hello Node Js</h1>");
});
server.listen(3000);
console.log("server 3000 portunda çalışmaya başladı");
