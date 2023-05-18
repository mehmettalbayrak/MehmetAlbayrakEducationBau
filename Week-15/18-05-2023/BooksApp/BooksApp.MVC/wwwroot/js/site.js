function btnAddToCardChange(id, price) {
    const ad = "btn-add-to-card-" + id;
    const element = document.getElementById(ad);
    element.innerText = "Sepete Ekle";
}

function btnAddToCardBack(id, price) {
    const ad = "btn-add-to-card-" + id;
    const element = document.getElementById(ad);
    element.innerText = price;
}