/*
    node js modüllerden oluşur. Bu modüllerin bazılarını biz hazırlarız. Bazıları ise built-in olarak node js modülü olarak bilinir. Ve hazırdır. Sadece dahil etmemiz gerekir.
*/

const http = require('http');

const server = http.createServer((request, response) => {
    if (request.url == '/') {
        response.write('<h1>Home Page</h1>');
        response.end();
    }
    else if (request.url == '/products') {
        response.write("<h1>Products</h1>");
        response.end();
    }
    else if (request.url == '/categories') {
        response.write("<h1>Categories</h1>");
        response.end();
    }
    else {
        response.write('<h1>404 Not Found!</h1>');
        response.end();
    }
});

//categories şeklinde bir isteği de karşılayın.
server.listen(3000);
console.log('server 3000 portunda çalışmaya başladı...');