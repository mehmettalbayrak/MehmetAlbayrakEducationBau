let sayilar = [5, 15, 20];

//Bu dizideki elemanları toplayan bir kod yazınız.

// let toplam = 0;
// for (const sayi of sayilar) {
//   toplam += sayi;
// }
// console.log(toplam);

// let sonuc = sayilar.reduce((pre, cur, index) => {
//   console.log(pre, cur, index);
//   return pre + cur;
// });

// const toplam = sayilar.reduce((t, s, i) => {
//   return t + s;
// }, 0);
// const toplam = sayilar.reduce((t, s) => t + s);

// console.log(toplam);

//sayilar dizisindeki tüm değerleri 2 ile çarpıp yeni sayilar dizisine aktaran kodu yazınız. (Map kullan).

// let sonuc = sayilar.map((s) => {
//   return s * 2;
// });
// console.log(sonuc);

const yeniSayilar = sayilar.reduce((dizi, sayi) => {
  dizi.push(sayi * 2);
  return dizi;
}, []);
console.log(sayilar);
console.log(yeniSayilar);
