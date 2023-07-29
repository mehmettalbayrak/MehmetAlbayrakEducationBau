import { useState } from "react";

function Header({ title, name }) {
  return <h1>{title + " " + (name ? name : "Icardi")}</h1>;
}

export default function HomePage() {
  const [likes, setLikes] = useState(0);
  function handleClick() {
    setLikes(likes + 1);
  }
  const names = ["Hilal", "Mertcan", "Eren"];
  return (
    <>
      <div>
        <Header title="Merhaba" name="arkadaşlar" />
        <ul>
          {names.map((name) => (
            <li key={name}>{name}</li>
          ))}
        </ul>
        <button onClick={handleClick}>Like ({likes})</button>
      </div>
    </>
  );
}
