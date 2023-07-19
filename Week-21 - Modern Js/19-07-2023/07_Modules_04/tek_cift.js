//Rastgele üretilen 1-100 arasondaki 10 adet sayıdan;
//1) Tek sayıları tespit edip bir diziye aktaran,
//2) Çift sayıları tespit edip bir diziye aktaran.
//functionları hazırlayalım.

export const rastgeleSayilar = () => {
  const dizi = [];
  for (let i = 0; i < 10; i++) {
    dizi.push(Math.floor(Math.random() * 100) + 1);
  }
  return dizi;
};

export const tekSayilar = (sayilar) => {
  const dizi = [];
  for (let i = 0; i < 10; i++) {
    if (sayilar[i] % 2 == 1) {
      dizi.push(sayilar[i]);
    }
  }
  return dizi;
};

export const ciftSayilar = (sayilar) => {
  const dizi = [];
  for (let i = 0; i < 10; i++) {
    if (sayilar[i] % 2 == 0) {
      dizi.push(sayilar[i]);
    }
  }
  return dizi;
};
