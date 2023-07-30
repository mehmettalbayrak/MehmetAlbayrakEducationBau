import React from "react";
import Header from "../components/header/header.js";
import Main from "../components/main/main.js";
import Footer from "../components/footer/footer.js";
import Layout from "../components/Layout/layout.js";

export default function Index() {
  return (
    <>
      <Layout>
        <Header />
        <Main />
        <Footer />
      </Layout>
    </>
  );
}
