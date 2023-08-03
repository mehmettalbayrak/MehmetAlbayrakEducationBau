import Link from 'next/link';
import Image from 'next/image';
import TopMenu from '../../components/top-menu';

export default function FirstPost() {
    return (
        <>
        <TopMenu />
            <h1>First Post</h1>
            <Image
                src='/images/01.jpg'
                width={144}
                height={200}
            />
            <Link href='/'>Ana Sayfa</Link>
        </>
    );
}