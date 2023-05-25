"use strict";

const inputTaskName = document.querySelector("#input-new-task");
const btnNewTask = document.querySelector("#btn-new-task");
const btnClear = document.querySelector("#btn-clear");
const taskList = document.querySelector("#tasks-list");

let isEditMode = false; //Kullanıcının o anda yeni kayıt mı yoksa düzenleme modunda mı olduğunu burada kontrol edeceğiz. Eğer bu false ise yeni kayıt modundayız (ekle). True ise düzeltme modundayız.
let editedTaskId; //O anda hangi görevi düzenliyoruz bilgisini uygulama boyunca kullanmak için tanımlandı.
let filterMode = "all";

let taskListArray = [
  //Örnek data gireceğimiz dizi. Veri kaynağımız. İleride local storage'de ne yazacaksa buraya dolduracağız. Yani boş kalacak. Burayı kendi storage'in olarak düşünebilirsin memo.
];
getLocalStorage();

btnNewTask.addEventListener("click", addNewTask); //addEventListener bu buttona tıklanabilir ya da bir eylem yapılabilir gibi durumlarda kullanılır.("tıklanınca demek olur", daha önce yazılan ya da burada yazılan functionı koyarız. Ve bu fonksiyon tıklanınca çalışır.)
btnClear.addEventListener("click", clearAll);

function addNewTask(e) {
  e.preventDefault();
  let value = inputTaskName.value.trim();
  if (value != "") {
    let id =
      taskListArray.length == 0
        ? 1
        : taskListArray[taskListArray.length - 1].id + 1;
    taskListArray.push({
      id: id,
      name: value,
      status: "pending",
    });
    saveLocalStorage();
  } else {
    alert("Lütfen görev adını boş bırakmayınız!");
  }
  inputTaskName.value = "";
  inputTaskName.focus();
  displayTasks();
}

function clearAll() {
  taskListArray = [];
  saveLocalStorage();
  displayTasks();
}

function displayTasks() {
  //Bu function HER İHTİYAÇ duyulduğunda tüm görevleri yeniden ekranda göstermek için kullanılacak.
  taskList.innerHTML = ""; //Bu komut html'de yazılı olan bilgileri sayfadan siler. Bu örnekte li lerimiz.
  if (taskListArray.length == 0) {
    taskList.innerHTML =
      '<div class="alert">Burada görev bulunmamaktadır!</div>';
  } else {
    for (let task of taskListArray) {
      //taskListArray'de dönüp dönen elemanları task yapar.
      let completed = task.status == "completed" ? "checked" : ""; //task status eğer completed ise checked yap değilse boş bırak.
      if (filterMode == "all") {
        let taskLi = `
    <li class="task-container" id="${task.id}">
        <div class="task-header">
            <input onclick="updateStatus(this);" class="task-check" type="checkbox" id="${task.id}" ${completed}>
            <input id="_${task.id}" class="task-name ${completed}" type="text" value="${task.name}" disabled>
        </div>
        <div class="btn-group">
            <button id="${task.id}" onclick="updateTask(this);" class="btn-edit">Düzenle</button>
            <button id="${task.id}" onclick="deleteTask(this);" class="btn-delete">Sil</button>
        </div>
    </li>
`;
        taskList.insertAdjacentHTML("beforeend", taskLi); //Her eklenen yeni görevin nereye ekleneceğini belirleriz. Before end eklenecek yer olarak belirtilen elementin kapanış taginin öncesine eklemesini sağlar. beforeend gibi 3 tane daha var bunlar da başlangıçtan sonra ya da önce ya da kapanıştan sonra ya da önce.
      }
    }
  }
}

function updateStatus(selectedTask) {
  let newStatus = selectedTask.checked ? "completed" : "pending";
  console.log(newStatus);
  for (const i in taskListArray) {
    if (selectedTask.id == taskListArray[i].id) {
      taskListArray[i].status = newStatus;
      saveLocalStorage();
    }
  }
  displayTasks();
}

function updateTask(clickedButton) {

    let editedTask = clickedButton.parentElement.previousElementSibling.lastElementChild;
    const liList = document.querySelectorAll(".task-container");
    for (const li of liList) {
        if (clickedButton.id != li.id) {
            li.firstElementChild.lastElementChild.setAttribute("disabled", "disabled");
            li.lastElementChild.firstElementChild.innerText = "Düzenle";
            li.lastElementChild.firstElementChild.classList.remove("clicked-button");
        } else {
            if (li.lastElementChild.firstElementChild.innerText == "Kaydet") {
                li.firstElementChild.lastElementChild.setAttribute("disabled", "disabled");
                li.lastElementChild.firstElementChild.innerText = "Düzenle";
                li.lastElementChild.firstElementChild.classList.remove("clicked-button");
                for (let i = 0; i < taskListArray.length; i++) {
                    if (clickedButton.id == taskListArray[i].id) {
                        taskListArray[i].name = editedTask.value;
                        saveLocalStorage();
                        // displayTasks();
                    }
                }
            } else {
                li.firstElementChild.lastElementChild.removeAttribute("disabled");
                li.lastElementChild.firstElementChild.innerText = "Kaydet";
                li.lastElementChild.firstElementChild.classList.add("clicked-button");
            }
        }
    }
    console.log(taskListArray);
    editedTask.focus();
}

function getLocalStorage() {
    if (localStorage.getItem("tasks") != null) {
        taskListArray = JSON.parse(localStorage.getItem("tasks"));
    }
}

function saveLocalStorage() {
    localStorage.setItem("tasks", JSON.stringify(taskListArray));
}

displayTasks();