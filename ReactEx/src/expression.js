var root = document.getElementById("root");

/* İfadeler */
var name = "Redmi Note 9";
var price = 4000;
var description = "bu bir sıfır telefondur.";

var expressionTemplate =
    <>
        <div id="productDetail">
            <div id="productName">Name : {name}</div>
            <div id="productPrice">Price : {price}TL</div>
            <div id="productDesc">Description : {description}</div>
        </div>
    </>;


var product = {
    name: "Samsung Phone",
    price: 7000,
    description: "çok kötü bir telefondur."
}

function formatPrice(p) {
    return p.price + " TL dir.";
}

var expressionTemplate1 =
    <>
        <div id="productDetail">
            <div id="productName">Name : {product.name}</div>
            <div id="productPrice">Price : {formatPrice(product)}</div>
            <div id="productDesc">Description : {product.description}</div>
        </div>
    </>;

/* ReactDOM */
ReactDOM.render(expressionTemplate1, root);