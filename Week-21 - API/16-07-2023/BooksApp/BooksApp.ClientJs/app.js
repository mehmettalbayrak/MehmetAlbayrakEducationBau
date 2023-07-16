const btnBooks = document.getElementById("btn-books");
const btnPublishers = document.getElementById("btn-publishers");
const resultsDiv = document.getElementById("results");

btnBooks.addEventListener('click', getBooks);
btnPublishers.addEventListener('click', getPublishers);

async function getBooks() {
    let response = await fetch("http://localhost:5201/api/books");
    if (response.ok === true) {
        let jsonResponse = await response.json();
        setBooks(jsonResponse.Data);
    }
    else {
        console.log("Hata:", response.statusText);
    }
}

async function getBooksDetails(id) {
    let response = await fetch(`http://localhost:5201/api/books/${id}`);
    if (response.ok === true) {
        let jsonResponse = await response.json();
        setBookDetails(jsonResponse.Data);
    }
}

async function getPublishers() {
    let response = await fetch("http://localhost:5201/api/publishers");

    if (response.ok === true) {
        let jsonResponse = await response.json();
        setPublishers(jsonResponse.Data);
    }
    else {
        console.log("Hata:", response.statusText);
    }
}

function setPublishers(publishers) {
    resultsDiv.innerHTML = "";
    publishers.forEach(publisher => {
        resultsDiv.innerHTML += `
        <div>
            <p>${publisher.Name}</p>
        </div>
        `;
    });
}

function setBooks(books) {
    resultsDiv.innerHTML = "";
    books.forEach(book => {
        resultsDiv.innerHTML += `
            <div>
            <p class="item" onclick="getBooksDetails(${book.Id})">${book.Name}</p>
            </div>
        `;
    });
}

function setBookDetails(book) {
    resultsDiv.innerHTML = `
    <div>
        <div class="row">
            <div class="col-3">
                <img src="http://localhost:5201/images/books/${book.ImageUrl}" />
            </div>
            <div class="col-9">
                <div class="row">
                    <div class="col-12">
                        <span class="text-danger">Kitap:</span>
                        <span>${book.Name}</span>
                    </div>
                    <div class="col-12">
                        <span class="text-danger">Yazar:</span>
                        <span>${book.Author.FirstName} ${book.Author.LastName}</span>
                    </div>
                    <div class="col-12">
                        <span class="text-danger">Yayınevi:</span>
                        <span>${book.Publisher.Name}</span>
                    </div>
                    <div class="col-12">
                        <span class="text-danger">Basım Yılı:</span>
                        <span>${book.EditionYear}</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    `
}

