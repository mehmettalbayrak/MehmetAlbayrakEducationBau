import React from "react";
import { useState, useEffect } from "react";
import Todo from "@/components/Todo";

export default function Todos() {
  const [todos, setTodos] = useState([]);

  useEffect(() => {
    setTodos(JSON.parse(localStorage.getItem("todos")));
  }, []);

  return (
    <section className="text-gray-600 body-font">
      <div className="container px-5 py-24 mx-auto">
        <div className="flex flex-col text-center w-full mb-20">
          <h1 className="text-2xl font-medium title-font mb-4 text-gray-900">
            Görevlerim
          </h1>
          <p className="lg:w-2/3 mx-auto leading-relaxed text-base">
            Daha önceden tanımlanmış görevler, burada.
          </p>
        </div>
        <div className="flex flex-wrap -m-4">
          {todos.map((todo) => (
            <Todo key={todo.title} todo={todo} />
          ))}
        </div>
      </div>
    </section>
  );
}
