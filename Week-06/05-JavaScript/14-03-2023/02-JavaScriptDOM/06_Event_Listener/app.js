'use strict';

let gorevListesi = [
    { id: 1, gorevAciklamasi: "Netflixi kapat" },
    { id: 2, gorevAciklamasi: "Pilavı unutma" },
    { id: 3, gorevAciklamasi: "Ahmeti ara" },
    { id: 4, gorevAciklamasi: "Toplantıyı planla" },
    { id: 5, gorevAciklamasi: "Yemek ye!" }
];

let ul = document.getElementById("task-list");

for (const gorev of gorevListesi) {
    let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAciklamasi}</label>
            </div>
        </li>
    `;
    ul.insertAdjacentHTML("beforeend", li);
}

let btnTextTaskAdd = document.querySelector("#btn-task-add");
btnTextTaskAdd.addEventListener("click", addNewTask);
function addNewTask(event) {
    event.preventDefault(); //eylemin çalışmasını default hale getirir ve consolda görüp test etmemizi ya da incelememizi ya da gerçekten eylemi durdurup o halde kalmasını sağlar.
    // console.log(event);
    // event.target.classList.add("btn-warning");
    let btn = event.target;
    if (btn.classList.contains("btn-warning")) {
        btn.classList.remove("btn-warning");
    } else {
        btn.classList.add("btn-warning");
    } 
}

