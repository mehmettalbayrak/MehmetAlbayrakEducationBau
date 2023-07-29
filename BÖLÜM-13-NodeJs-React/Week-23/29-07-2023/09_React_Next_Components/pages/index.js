import { useState } from "react";

function Header({ title, name }) {
  return <h1>{title + " " + (name ? name : "Icardi")}</h1>;
}

function Friends(props) {
  return (
    <ul>
      {props.friends.map((name) => (
        <li key={name}>{name}</li>
      ))}
    </ul>
  );
}

function Likes() {
  const [likes, setLikes] = useState(0);
  function handleClick() {
    setLikes(likes + 1);
  }
  return <button onClick={handleClick}>Like ({likes})</button>;
}

export default function HomePage() {
  const names = ["Zaha", "Icardi", "Rashica"];
  return (
    <>
      <div>
        <Header title="Merhaba" name="arkadaşlar" />
        <Friends friends={names} />
        <Likes />
      </div>
    </>
  );
}
