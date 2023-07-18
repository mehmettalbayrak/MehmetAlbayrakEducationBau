//Rest Parameters
// const topla = (sayi1, sayi2, sayi3) => {
//   return sayi1 + sayi2 + sayi3;
// };

// console.log(topla(5, 10, 15));

// const topla = (...sayilar) => {
//   let toplam = 0;
//   sayilar.forEach((sayi) => {
//     toplam += sayi;
//   });
//   return toplam;
// };

// console.log(topla(5, 10, 15));

//Dairenin alanını hesaplayan function.

// const calculateCircleArea = (r, PI = 3) => {
//   return PI * r * r;
// };
// console.log(calculateCircleArea(5));

// const products1 = ["adidas", "puma", "nike"];
// const products2 = products1;
// products1.push("hummel");
// console.log(products1);
// console.log(products2);

const products1 = ["adidas", "puma", "nike"];
const products2 = [...products1];
products1.push("hummel");
console.log(products1);
console.log(products2);
