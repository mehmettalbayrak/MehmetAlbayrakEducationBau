// let sayilar = [5, 9, 56, 15, 28, 75, 99];
// let tekSayilar = sayilar.map((x) => {
//   if (x % 2 === 1) {
//     return x;
//   }
// });
// console.log(tekSayilar);

// let ciftSayilar = sayilar.map((x) => {
//   if (x % 2 === 0) {
//     return x;
//   }
// });
// console.log(ciftSayilar);

const products = [
  { id: 1, name: "Ayakkabı", price: 780, stok: 25 },
  { id: 2, name: "T-Shirt", price: 325, stok: 45 },
  { id: 3, name: "Pantalon", price: 432, stok: 22 },
  { id: 4, name: "Telefon", price: 7654, stok: 14 },
  { id: 5, name: "Saat", price: 7800, stok: 53 },
];
let stok = [];
for (let i = 0; i < 5; i++) {
  stok.push(products[i].stok);
}
console.log(stok);

const stocks = products.map(stok) => (products.stok);

