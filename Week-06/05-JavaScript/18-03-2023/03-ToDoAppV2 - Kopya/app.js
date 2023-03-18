"use strict"

const inputTaskName = document.querySelector("#input-new-task");
const btnNewTask = document.querySelector("#btn-new-task");
const btnClear = document.querySelector("#btn-clear");
const taskList = document.querySelector("#tasks-list");

let isEditMode = false; //Kullanıcının o anda yeni kayıt mı yoksa düzenleme modunda mı olduğunu burada kontrol edeceğiz. Eğer bu false ise yeni kayıt modundayız (ekle). True ise düzeltme modundayız.
let editedTaskId; //O anda hangi görevi düzenliyoruz bilgisini uygulama boyunca kullanmak için tanımlandı.
let filterMode = "all";

let taskListArray = [
    //Örnek data gireceğimiz dizi. Veri kaynağımız. İleride local storage'de ne yazacaksa buraya dolduracağız. Yani boş kalacak. Burayı kendi storage'in olarak düşünebilirsin memo.
    { "id": 1, "name": "Spotify faturasını öde", "status": "pending" },
    { "id": 2, "name": "Digiturk faturasını öde", "status": "pending" },
    { "id": 3, "name": "Turknet faturasını öde", "status": "completed" },
    { "id": 4, "name": "Netflix faturasını öde", "status": "pending" },
    { "id": 5, "name": "Disney+ faturasını öde", "status": "pending" }
];

btnNewTask.addEventListener("click", addNewTask); //addEventListener bu buttona tıklanabilir ya da bir eylem yapılabilir gibi durumlarda kullanılır.("tıklanınca demek olur", daha önce yazılan ya da burada yazılan functionı koyarız. Ve bu fonksiyon tıklanınca çalışır.)
btnClear.addEventListener("click", clearAll);

function addNewTask(e) {
    e.preventDefault()
    let value = inputTaskName.value.trim()
    if (value != "") {
        if (!isEditMode) {
            //Eğer yeni kayıt modundaysan
            let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
            taskListArray.push(
                {
                    "id": id,
                    "name": inputTaskName.value,
                    "status": "pending"
                }
            )
        } else {
            //Eğer edit ya da düzenleme modundaysa
        }
    } else {
        alert("Lütfen görev adını boş bırakmayınız!");
    }
    inputTaskName.value = "";
    inputTaskName.focus();
    displayTasks();
}

function clearAll() {

}

function displayTasks() {
    //Bu function HER İHTİYAÇ duyulduğunda tüm görevleri yeniden ekranda göstermek için kullanılacak.
    taskList.innerHTML = ""; //Bu komut html'de yazılı olan bilgileri sayfadan siler. Bu örnekte li lerimiz.
    if (taskListArray.length === 0) {
        taskList.innerHTML = '<div class="alert">Burada görev bulunmamaktadır!</div>'
    }
    for (let task of taskListArray) { //taskListArray'de dönüp dönen elemanları task yapar.
        let completed = task.status == "completed" ? "checked" : ""; //task status eğer completed ise checked yap değilse boş bırak.
        if (filterMode == 'all') {
            let taskLi = `
            <li class="task-container">
          <div class="task-header">
            <input onclick="updateStatus(this);" class="task-check" type="checkbox" id="${task.id}" ${completed}>
            <input id = "_${task.id}" class="task-input ${completed}" type="text" value="${task.name}" disabled>
          </div>
          <div class="btn-group">
            <button onclick="updateTask(${task.id});" class="btn-edit">
              Düzenle
            </button>
            <button onclick="deleteTask(${task.id})"; class="btn-delete">
              Sil
            </button>
          </div>
        </li> 
        `;
            taskList.insertAdjacentHTML("beforeend", taskLi) //Her eklenen yeni görevin nereye ekleneceğini belirleriz. Before end eklenecek yer olarak belirtilen elementin kapanış taginin öncesine eklemesini sağlar. beforeend gibi 3 tane daha var bunlar da başlangıçtan sonra ya da önce ya da kapanıştan sonra ya da önce.
        }

    }
}


function updateStatus(selectedTask) {
    let updatedTaskId;
    let newStatus = selectedTask.checked ? "completed" : "pending";
    for (const i in taskListArray) {
        if (selectedTask.id == taskListArray[i].id) {
            taskListArray[i].status = newStatus;
        }
    }
    displayTasks(filterMode);
}
displayTasks(filterMode);