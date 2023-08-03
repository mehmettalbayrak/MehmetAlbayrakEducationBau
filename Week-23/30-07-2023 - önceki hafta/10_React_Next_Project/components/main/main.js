import React from "react";
import MainMenu from '../mainmenu/mainmenu';
import MainContent from '../maincontent/maincontent';
import styles from './main.module.css';

export default function Main() {
    return (
        <div className={styles.container}>
            <MainMenu />
            <MainContent />
        </div>
    );
}