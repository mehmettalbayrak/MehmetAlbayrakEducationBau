/*
    node js modüllerden oluşur. Bu modüllerin bazılarını biz hazırlarız. Bazıları ise built-in olarak node js modülü olarak bilinir. Ve hazırdır. Sadece dahil etmemiz gerekir.
*/

const http = require('http');
const server = http.createServer((request, response) => {
    response.write('<h1>Hello Node js</h1>');
    response.end();
});
server.listen(3000);
console.log('server 3000 portunda çalışmaya başladı...');