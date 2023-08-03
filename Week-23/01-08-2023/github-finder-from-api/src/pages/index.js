import Navbar from '@/components/navbar';
import User from '@/components/user';
import Head from 'next/head';
import Axios from 'axios';
import { useState } from 'react';

export default function Home() {
  const [users, setUsers] = useState([]);

  Axios
    .get('https://api.github.com/users')
    .then(response => setUsers(response.data));

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
        {
          users.map(user => (
            <User key={user.id} user={user} />
          ))
        }
      </main>

    </>
  )
}
