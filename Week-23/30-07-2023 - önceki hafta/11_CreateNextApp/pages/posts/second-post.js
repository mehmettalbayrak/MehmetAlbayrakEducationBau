import Link from 'next/link';
import Image from 'next/image';
import TopMenu from '../../components/top-menu';

export default function SecondPost() {
    return (
        <>
            <TopMenu />
            <h1>Second Post</h1>
            <Image
                src='/images/02.jpg'
                width={144}
                height={200}
                alt={"Selam"}
            />
            <Link href='/'>Ana Sayfa</Link>
        </>
    );
}