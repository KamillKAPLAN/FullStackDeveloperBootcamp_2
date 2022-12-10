var root = document.getElementById("root");

/* Koşul İfadeleri */
var product2 = {
    name: "Samsung Phone 2",
    price: 8000,
    description: "Samsung Phone 2 decription",
    type: ["red", "blue"]
}

function getDescription(descriptionn) {
    // if (descriptionn) {
    //     return descriptionn;
    // }
    // else {
    //     return "no-description";
    // }

    if (descriptionn) {
        return <div id="productDesc">Description : {descriptionn}</div>
    }
}

var conditionalTemplate = (
    <div id="productDetail">
        <div id="productName">Name : {product2.name}</div>
        <div id="productPrice">Price : {product2.price == 0 ? "free" : product2.price}</div>
        {(product2.price && product2.price > 0) && <div id="productPrice">Price : {product2.price} TL</div>}
        {/* <div id="productDesc">Description : {getDescription(product2.description)}</div> */}
        {getDescription(product2.description)}
        <p>{product2.type.length > 0 ? "seçenek var" : "seçenek yok"}</p>
    </div>
);

/* ReactDOM */
ReactDOM.render(conditionalTemplate, root);