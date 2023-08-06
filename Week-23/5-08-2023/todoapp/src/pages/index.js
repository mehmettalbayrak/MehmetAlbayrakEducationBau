import { Inter } from "next/font/google";
import { useState } from "react";

const inter = Inter({ subsets: ["latin"] });

export default function Home() {
  const [todo, setTodo] = useState({ title: "", desc: "" });
  const onChange = (e) => {
    setTodo({ ...todo, [e.target.name]: e.target.value });
  };

  const addToDo = () => {
    let todos = localStorage.getItem("todos");
    console.log(todos);
    if (todos) {
      
    } else {
      localStorage.setItem("todos", JSON.stringify([todo]));
    }
  };

  return (
    <>
      <section className="text-gray-400 bg-gray-900 body-font">
        <div className="container px-5 py-6 mx-auto flex flex-wrap items-center">
          <div className="w-full bg-gray-800 bg-opacity-50 rounded-lg p-8 flex flex-col md:ml-auto w-full mt-10 md:mt-0">
            <h2 className="text-white text-lg font-medium title-font mb-5">
              Görev Ekle
            </h2>
            <div className="relative mb-4">
              <label
                htmlFor="title"
                className="leading-7 text-sm text-gray-400"
              >
                Başlık
              </label>
              <input
                onChange={onChange}
                value={todo.title}
                type="text"
                id="title"
                name="title"
                className="w-full bg-gray-600 bg-opacity-20 focus:bg-transparent focus:ring-2 focus:ring-indigo-900 rounded border border-gray-600 focus:border-indigo-500 text-base outline-none text-gray-100 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"
              ></input>
            </div>
            <div className="relative mb-4">
              <label htmlFor="desc" className="leading-7 text-sm text-gray-400">
                Açıklama
              </label>
              <input
                onChange={onChange}
                value={todo.desc}
                type="desc"
                id="desc"
                name="desc"
                className="w-full bg-gray-600 bg-opacity-20 focus:bg-transparent focus:ring-2 focus:ring-indigo-900 rounded border border-gray-600 focus:border-indigo-500 text-base outline-none text-gray-100 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"
              ></input>
            </div>
            <button
              onClick={addToDo}
              className="text-white bg-indigo-500 border-0 py-2 px-8 focus:outline-none hover:bg-indigo-600 rounded text-lg"
            >
              Görevi Ekle
            </button>
            <p className="text-xs mt-3">
              Son kez kontrol ettin mi? Görevini eklemeden önce son kez kontrol
              etmen her zaman önemlidir.
            </p>
          </div>
        </div>
      </section>
    </>
  );
}
