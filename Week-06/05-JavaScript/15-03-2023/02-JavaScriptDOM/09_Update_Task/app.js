'use strict';
let btnAdd = document.querySelector("#btn-task-add");
let txtTaskDesc = document.querySelector("#text-task-description");
let btnClear = document.querySelector("#btn-clear-all");
let ul = document.querySelector("#task-list");

let isEditMode = false; //Eğer isEditMode false ise YENİ KAYIT modundayız, true ise KAYIT DÜZELTME modundayız
let editedId;

btnAdd.addEventListener("click", newTask);
btnClear.addEventListener("click", clearAll);

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
                                <input type="checkbox" id="${gorev.id}" class="form-check-input" onclick = "updateStatus();">
                                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAciklamasi}</label>
                            </div>
                            <div class="dropdown">
                                <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown"><i
                                        class="fa-solid fa-ellipsis"></i></button>
                                <ul class="dropdown-menu">
                                    <li><a href="#" class="dropdown-item" onclick="deleteTask(${gorev.id});">Sil</a></li>
                                    <li><a href="#" class="dropdown-item" onclick="updateTask(${gorev.id}, '${gorev.gorevAciklamasi}')">Düzenle</a></li>
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
        if (!isEditMode) {
            gorevListesi.push(
                {
                    id: gorevListesi[gorevListesi.length - 1].id + 1,
                    gorevAciklamasi: txtTaskDesc.value
                }
            );
        }
        displayTasks();
        txtTaskDesc.value = '';
        txtTaskDesc.focus();
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız!");
    }
}

function clearAll() {
    let answer = confirm('Tüm görevler silinecek!');
    if (answer) {
        gorevListesi.splice(0);
        displayTasks();
        alert("Tüm görevler başarıyla silinmiştir.");
    }

}

function deleteTask(id) {
    let deletedIndex;
    for (const gorevIndex in gorevListesi) {
        if (gorevListesi[gorevIndex].id == id) {
            deletedIndex = gorevIndex;
        }
    }
    let answer = confirm(gorevListesi[deletedIndex].gorevAciklamasi + " adlı görev silinecektir!");
    if (answer) {
        gorevListesi.splice(deletedIndex, 1);
        displayTasks();
        alert("Silme işlemi başarıyla tamamlanmıştır!");
    }
}

function updateTask(id, gorevAciklamasi) {
    editedId = id;
    isEditMode = true;
    txtTaskDesc.value = gorevAciklamasi;
    txtTaskDesc.focus();
    btnAdd.innerText = "Değişiklikleri Kaydet";
    btnAdd.classList.add("btn-warning");
    ul.disabled = true;

}


function isFull(value) {
    if (value.trim() == '') {
        return false;
    }

    return true;
}

displayTasks();