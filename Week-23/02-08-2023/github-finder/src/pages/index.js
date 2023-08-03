import Navbar from '@/components/navbar';
import User from '@/components/user';
import Head from 'next/head';

export default function Home() {
  const users = [
    {
      id: "99557344",
      avatar_url: "https://avatars.githubusercontent.com/u/99557344?v=4",
      login: "enginhoca",
      html_url: "https://github.com/enginhoca"
    },
    {
      id: "1",
      avatar_url: "https://avatars.githubusercontent.com/u/1?v=4",
      login: "mojombo",
      html_url: "https://github.com/mojombo"
    },
    {
      id: "2",
      avatar_url: "https://avatars.githubusercontent.com/u/3?v=4",
      login: "defunkt",
      html_url: "https://github.com/defunkt"
    }
  ];
  
  return (
    <>
      <Head>
        <title>Github Finder</title>
        <meta name="description" content="Brigth 2023-1 grubu tarafından hazırlanmıştır" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <main className="container mt-3 d-flex flex-column justify-content-center align-items-center">
        <Navbar />
        <User user={users[0]} />
        <User user={users[1]} />
        <User user={users[2]} />
      </main>

    </>
  )
}
