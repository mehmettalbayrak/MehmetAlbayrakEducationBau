const http = require('http');
const fs = require('fs');

const server = http.createServer((request, response) => {
    if (request.url == '/') {
        fs.readFile('index.html', (error, html) => {
            response.writeHead(200, { "Content-Type": "text/html" });
            response.write(html);
            response.end();
        });
    }
    else if (request.url == '/products') {
        fs.readFile('products.html', (error, html) => {
            response.writeHead(200, { "Content-Type": "text/html" });
            response.write(html);
            response.end();
        });
    }
    else if (request.url == '/categories') {
        fs.readFile('categories.html', (error, html) => {
            response.writeHead(200, { "Content-Type": "text/html" });
            response.write(html);
            response.end();
        });
    }
    else if (request.url == '/create' && request.method == 'POST') {
        const data = [];
        request.on('data', (chunk) => {
            data.push(chunk);
        });
        request.on('end', () => {
            const result = Buffer.concat(data).toString();
            const parsedData = result.split('=')[1];

            fs.appendFile('data.txt', parsedData, (error) => {
                if (error) {
                    console.log(error);
                } else {
                    response.statusCode = 302;
                    response.setHeader("Location", "/");
                    response.end();
                }
            });
        });
    }
    else if (request.url == '/create') {
        fs.readFile('create.html', (error, html) => {
            response.writeHead(200, { "Content-Type": "text/html" });
            response.write(html);
            response.end();
        });
    }
    else {

        fs.readFile('404.html', (error, html) => {
            response.writeHead(200, { "Content-Type": "text/html" });
            response.write(html);
            response.end();
        });
    }
});

//categories şeklinde bir isteği de karşılayın.
server.listen(3000);
console.log('server 3000 portunda çalışmaya başladı...');