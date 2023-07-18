const topla = (...sayilar) => {
  let toplam = 0;
  for (let i = 0; i < [...sayilar].length; i++) {
    toplam = [...sayilar][i];
  }
  return toplam;
};

module.exports = topla;
