// let fullName = ["Murat", "Boz"];
// let firstName = fullName[0];
// let lastName = fullName[1];
// console.log(firstName);
// console.log(lastName);

// let fullName = ["Mauro", "Icardi"];
// let [firstName, lastName] = [...fullName];
// console.log(firstName);
// console.log(lastName);

// let userInfo = ["Mehmet", "Albayrak", "İstanbul", "Türkiye"];
// let [firstName, lastName, , country] = [...userInfo];
// console.log(firstName);
// console.log(lastName);
// console.log(country);

// let userInfo = ["Mehmet", "Albayrak", "İstanbul", "Türkiye"];
// let [firstName, lastName, ...address] = [...userInfo];
// console.log(firstName);
// console.log(lastName);
// console.log(...address);

// let firstName = "Didier";
// let lastName = "Drogba";
// console.log("ilk hali: ", firstName, lastName);

//Nesne destructring
let product = {
  brandName: "Adidas",
  model: "Super Star",
  price: 4499,
};

let { brandName, model, price } = product;
console.log(brandName, model, price);
