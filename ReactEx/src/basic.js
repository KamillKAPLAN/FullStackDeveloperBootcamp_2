var root = document.getElementById("root");

/* React JSX */
var template =
    <div>
        <p>Merhaba</p>
        <h1>TechCareer</h1>
        <h4>Bootcamp</h4>
    </div>;

var template1 =
    <>
        <h1>Merhaba FullStackBootcamp</h1>
        <div>Lorem, ipsum dolor.</div>
        <ul>
            <li>Lorem, ipsum.</li>
            <li>Lorem ipsum dolor sit.</li>
            <li>Lorem ipsum dolor sit amet consectetur.</li>
        </ul>
    </>;

var template2 =
    (
        <>
            <>
                <div id="productDetail">
                    <div id="productName">Name : Redmi Note 8</div>
                    <div id="productPrice">Price : 4000TL</div>
                    <div id="productDesc">Description : bu bir sıfır telefondur.</div>
                </div>
            </> <br />
            <>
                <div id="productDetail">
                    <div id="productName">Name : Redmi Note 8</div>
                    <div id="productPrice">Price : 4000TL</div>
                    <div id="productDesc">Description : bu bir sıfır telefondur.</div>
                </div>
            </>
        </>
    );

/* ReactDOM */
ReactDOM.render(template2, root);