import Link from 'next/link';

export default function TopMenu() {
    return (
        <>
            <div>
                <Link href="/">Home</Link> | <Link href="/posts/first-post">First Post</Link> | <Link href="/posts/second-post">Second Post</Link>
            </div>
        </>
    );
}