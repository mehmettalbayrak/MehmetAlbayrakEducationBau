//ES6 Öncesi
function Person(name, dateOfBirth) {
  this.name = name;
  this.dateOfBirth = dateOfBirth;
}

let person1 = new Person("Mertcan", 1995);
let person2 = new Person("Hilal", 1996);
console.log(person1);
console.log(person2);

//ES6 ve sonrası
//class keywordü.

