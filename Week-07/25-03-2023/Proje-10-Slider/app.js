const slides = document.querySelectorAll(".slide");
const btnPrev = document.querySelector("#prev");
const btnNext = document.querySelector("#next");
const headerSpan = document.querySelector(".header h1 span");

let autoSlider = true;
let sliderInterval;
let timerInterval;
let counter;
let intervalTime = 5000;

$("#prev").click(function () {
  prevSlide();
  againInterval();
});

$("#next").click(function () {
  nextSlide();
  againInterval();
});

// btnPrev.addEventListener("click", function () {
//     prevSlide();//Bu bir önceki slidea geçişi sağlayan func
//     againInterval();
// });

// btnNext.addEventListener("click", function () {
//     nextSlide();//Bu bir sonraki slidea geçişi sağlayan func
//     againInterval();
// });

function prevSlide() {
  let activeSlide = $(".active");
  activeSlide.removeClass("active");
}
if (activeSlide.prev().hasClass("slide")) {
  activeSlide.prev().addClass("active");
} else {
  $(".slide")[$(".slide").length - 1].addClass("active");
}

function nextSlide() {
  let activeSlide = document.querySelector(".active");
  activeSlide.classList.remove("active");
  if (
    activeSlide.nextElementSibling &&
    activeSlide.nextElementSibling.classList.contains("slide")
  ) {
    activeSlide.nextElementSibling.classList.add("active");
  } else {
    slides[0].classList.add("active");
  }
}

function againInterval() {
  if (autoSlider) {
    clearInterval(sliderInterval);
    clearInterval(timerInterval);
    counter = 1;
    headerSpan.innerText = `(${counter})`;
    sliderInterval = setInterval(nextSlide, intervalTime);
    timerInterval = setInterval(timerDisplay, 1000);
  }
}

if (autoSlider) {
  againInterval();
}

function timerDisplay() {
  counter++;
  headerSpan.innerText = `(${counter})`;
  if (counter > 5) againInterval();
}

//Zamanı başlığın yanında gösterin!
