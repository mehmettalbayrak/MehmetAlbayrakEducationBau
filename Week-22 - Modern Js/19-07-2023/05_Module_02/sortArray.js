const randomNumber = (maxNumber) => {
  return Math.floor(Math.random() * maxNumber) + 1;
};

const arrayASC = (array) => {
  return array.sort(compareNumericASC);
};

const arrayDESC = (array) => {
  return array.sort(compareNumericDESC);
};

const compareNumericDESC = (a, b) => {
  if (a > b) return -1;
  if (a == b) return 0;
  if (a < b) return 1;
};

const compareNumericASC = (a, b) => {
  if (a > b) return 1;
  if (a == b) return 0;
  if (a < b) return -1;
};

export { arrayASC, arrayDESC, randomNumber };
