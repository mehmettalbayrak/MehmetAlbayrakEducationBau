"use strict";
let btnAdd = document.querySelector("#btn-task-add");
let txtTaskDesc = document.querySelector("#text-task-description");
let btnClear = document.querySelector("#btn-clear-all");
let ul = document.querySelector("#task-list");
let filters = document.querySelectorAll("#filters span");

let isEditMode = false; //Eğer isEditMode false ise YENİ KAYIT modundayız, true ise KAYIT DÜZELTME modundayız
let editedId;
let filterMode = "all";
let arrayStatus = false;

btnAdd.addEventListener("click", newTask);
btnClear.addEventListener("click", clearAll);
for (const span of filters) {
  span.addEventListener("click", function () {
    document.querySelector("span.active").classList.remove("active");
    span.classList.add("active");
    filterMode = span.id;
    displayTasks(filterMode);
  });
}

let gorevListesi = [
  { id: 1, gorevAciklamasi: "Netflixi kapat", durum: "completed" },
  { id: 2, gorevAciklamasi: "Pilavı unutma", durum: "pending" },
  { id: 3, gorevAciklamasi: "Ahmeti ara", durum: "pending" },
  { id: 4, gorevAciklamasi: "Toplantıyı planla", durum: "completed" },
  { id: 5, gorevAciklamasi: "Yemek ye!", durum: "pending" },
];
function displayTasks(filter) {
  ul.innerHTML = "";
  arrayStatus = false;
  for (const gorev of gorevListesi) {
    let completed = gorev.durum == "completed" ? "checked" : "";
    if (filter == gorev.durum || filter == "all") {
      arrayStatus = true;
      console.log(arrayStatus);
      let li = `
                    <li class="task list-group-item d-flex justify-content-between align-items-center">
                            <div class="form-check">
                                <input type="checkbox" id="${gorev.id}" class="form-check-input" onclick="updateStatus(this);" ${completed}>
                                <label for="${gorev.id}" class="form-check-label ${completed}">${gorev.gorevAciklamasi}</label>
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
  if (arrayStatus === false) {
    let li =
      '<div class="alert alert-danger m-0" role="alert">Burada gösterilecek görev yok!</div> ';
    ul.insertAdjacentHTML("beforeend", li);
  }
}

function newTask(e) {
  e.preventDefault();
  if (isFull(txtTaskDesc.value)) {
    if (!isEditMode) {
      //Yeni Kayıt ekleme işlemleri
      gorevListesi.push({
        id: gorevListesi[gorevListesi.length - 1].id + 1,
        gorevAciklamasi: txtTaskDesc.value,
        durum: "pending",
      });
    } else {
      //Güncelleme işlemleri
      for (const gorev of gorevListesi) {
        if (gorev.id == editedId) {
          gorev.gorevAciklamasi = txtTaskDesc.value;
          isEditMode = false;
          btnAdd.innerText = "Ekle";
          btnAdd.classList.remove("btn-warning");
        }
      }
    }

    displayTasks(filterMode);
    txtTaskDesc.value = "";
    txtTaskDesc.focus();
  } else {
    alert("Lütfen görev açıklamasını boş bırakmayınız!");
  }
}

function clearAll() {
  let answer = confirm("Tüm görevler silinecek!");
  if (answer) {
    gorevListesi.splice(0);
    displayTasks(filterMode);
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
  let answer = confirm(
    gorevListesi[deletedIndex].gorevAciklamasi + " adlı görev silinecektir!"
  );
  if (answer) {
    gorevListesi.splice(deletedIndex, 1);
    displayTasks(filterMode);
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
}

function updateStatus(element) {
  let updatedIndex;
  for (const gorevIndex in gorevListesi) {
    if (gorevListesi[gorevIndex].id == element.id) {
      updatedIndex = gorevIndex;
    }
  }

  let label = element.nextElementSibling;
  if (element.checked) {
    label.classList.add("checked");
    gorevListesi[updatedIndex].durum = "completed";
  } else {
    label.classList.remove("checked");
    gorevListesi[updatedIndex].durum = "pending";
  }
  displayTasks(filterMode);
}

function isFull(value) {
  if (value.trim() == "") {
    return false;
  }

  return true;
}

displayTasks(filterMode);
