const clock = document.querySelector(".clock");

function tick() {
    const time = new Date();
    let hour = time.getHours();
    let minute = time.getMinutes();
    let second = time.getSeconds();

    const html = `<span>${hour}</span>:<span>${minute}</span>:<span>${second}</span>`; //html textini buraya yazdık.
    clock.innerHTML = html; //html kodunu html dosyasına göndermek için innerHTML komutunu kullanıyoruz.

}

setInterval(tick, 1000); //şu kadar sürede çalışacak bir kodum var demek. Default değeri 1000'dir.
