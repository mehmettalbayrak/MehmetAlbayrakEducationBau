import React from 'react';
import Header from '../components/header/header';
import Main from '../components/main/main';
import Footer from '../components/footer/footer';
import Layout from '../components/layout/layout';


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