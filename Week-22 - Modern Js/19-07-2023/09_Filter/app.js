// let sayilar = [5, 9, 56, 15, 28, 75, 99];

// let sonuc = sayilar.filter((siradakiSayi) => {
//   if (siradakiSayi > 30) {
//     return siradakiSayi;
//   }
// });

// let sonuc = sayilar.filter((siradakiSayi) => siradakiSayi > 15);

// console.log(sayilar);
// console.log(sonuc);

const products = [
  { name: "iPhone 14", category: "Telefon" },
  { name: "Dell XPS13", category: "Bilgisayar" },
  { name: "A4 Tech TRY55", category: "Mouse" },
  { name: "iPhone 15", category: "Telefon" },
  { name: "MacBook Air M2", category: "Bilgisayar" },
  { name: "Monster Tulpar T7", category: "Bilgisayar" },
];

const bilgisayarlar = products.filter((p) => {
  return p.category == "Bilgisayar";
});
console.log(bilgisayarlar);
