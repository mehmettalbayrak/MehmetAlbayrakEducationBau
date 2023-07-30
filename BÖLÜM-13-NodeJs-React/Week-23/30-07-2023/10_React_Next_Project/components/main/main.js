import React from "react";
import styles from "./main.module.css";
import MainContent from "../maincontent/maincontent";
import MainMenu from "../mainmenu/mainmenu";

export default function Main() {
  return (
    <>
      <div className={styles.paragraf}>
        <MainMenu />
        <MainContent />
      </div>
    </>
  );
}
