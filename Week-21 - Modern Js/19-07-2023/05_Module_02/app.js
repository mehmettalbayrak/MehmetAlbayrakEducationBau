import { randomNumber, arrayASC, arrayDESC } from "./sortArray.js";
const randomNumbers = [];
for (let i = 0; i < 5; i++) {
  randomNumbers.push(randomNumber(100));
}

console.log("Dizinin orijinal hali");
console.log(randomNumbers);
console.log("Küçükten büyüğe sıralanmış hali");
console.log(arrayASC(randomNumbers));
console.log("Büyükten küçüğe sıralanmış hali");
console.log(arrayDESC(randomNumbers));
