import React from "react";
import styles from "./header.module.css";

export default function Header() {
  return (
    <>
      <div className={styles.headerContainer}>
        <h1 className={styles.header}>Componentlerle İlgili Uygulama</h1>
      </div>
    </>
  );
}
