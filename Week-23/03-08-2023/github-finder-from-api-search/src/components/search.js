import React, { useState } from 'react'

export default function Search({ searchUsers, setLoading, showClearButton, clearResults }) {
    const [keyword, setKeyword] = useState("");

    const onChange = (e) => {
        setKeyword(e.target.value);
    }

    const onSubmit = (e) => {
        e.preventDefault();
        setLoading(true);
        setTimeout(() => {
            searchUsers(keyword);
        }, 2000);
    }

    const clear = () => {
        setKeyword("");
        clearResults();
    }

    return (
        <div className='w-100'>
            <form onSubmit={onSubmit}>
                <div className="input-group mb-3">
                    <input value={keyword} onChange={onChange} type="text" className="form-control" placeholder="Recipient's Github username" aria-label="Recipient's username" aria-describedby="button-addon2"></input>
                    <button className="btn btn-outline-secondary" type="submit" id="button-addon2">Search</button>
                </div>
            </form>

            {showClearButton && <div className='d-grid clearBtn'>
                <button onClick={clear} className='btn btn-danger mb-3'>Clear</button>
            </div>}
        </div>
    )
}
