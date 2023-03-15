'use strict';
let btnAdd = document.querySelector("#btn-task-add");
let txtTaskDesc = document.querySelector("#text-task-description");

btnAdd.addEventListener("click", newTask);

let gorevListesi = [
    { id: 1, gorevAciklamasi: "Netflixi kapat" },
    { id: 2, gorevAciklamasi: "Pilavı unutma" },
    { id: 3, gorevAciklamasi: "Ahmeti ara" },
    { id: 4, gorevAciklamasi: "Toplantıyı planla" },
    { id: 5, gorevAciklamasi: "Yemek ye!" }
];

function displayTasks() {
    let ul = document.getElementById("task-list");
    ul.innerHTML = '';
    for (const gorev of gorevListesi) {
        let li = `
                    <li class="task list-group-item d-flex justify-content-between align-items-center">
                            <div class="form-check">
                                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAciklamasi}</label>
                            </div>
                            <div class="dropdown">
                                <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown"><i
                                        class="fa-solid fa-ellipsis"></i></button>
                                <ul class="dropdown-menu">
                                    <li><a href="#" class="dropdown-item">Sil</a></li>
                                    <li><a href="#" class="dropdown-item">Düzenle</a></li>
                                </ul>
                            </div>
                    </li>
                        
    `;
        ul.insertAdjacentHTML("beforeend", li);
    }
}

function newTask(e) {
    e.preventDefault();
    if (isFull(txtTaskDesc.value)) {
        gorevListesi.push(
            {
                id: gorevListesi[gorevListesi.length - 1].id + 1,
                gorevAciklamasi: txtTaskDesc.value
            }
        );
        displayTasks();
        txtTaskDesc.value = '';
        txtTaskDesc.attributes();
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız!");
    }
}


function isFull(value) {
    if (value.trim() == '') {
        return false;
    }

    return true;
}

displayTasks();