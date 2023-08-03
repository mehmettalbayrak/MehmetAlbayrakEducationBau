//Kendisine gönderen sayının faktoriyelini hesaplayacak ve geri gönderecek bir function hazırlayacağız.
//Bu function export edilecek ve app.js içine import edilecek.

const calculateFactorial = (number) => {
  if (number === 0 || number === 1) {
    return 1;
  }

  for (let i = number - 1; i >= 1; i--) {
    number = number * i;
  }
  return number;
};

const init = () => {
  console.log("Mathematics modülü çalışmaya başladı.");
  console.log("Örnek Hesaplama:");
  console.log("5! hesabı:");
  console.log("calculateFactorial(5)");
  console.log("Sonuç: ", calculateFactorial(5));
};

export { calculateFactorial };
export default init;
