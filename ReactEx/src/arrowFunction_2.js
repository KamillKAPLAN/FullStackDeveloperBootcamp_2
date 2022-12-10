const root = document.getElementById("root");

const phones = [
    { name: "General Mobile", price: 3000 },
    { name: "Iphone 14", price: 20000 },
    { name: "Redmi Note 8", price: 5600 },
    { name: "Iphone X", price: 8000 },
];

/* ES5 */
let getPrice = phones.map(function (phone) {
    return phone.price
});
console.log(getPrice);
/* ES6 */
let price = phones.map(phone => phone.price);
console.log(price);

let filterES5 = phones.filter(function (phone) {
    return phone.price >= 5000;
});
console.log(filterES5);
let filterES6 = phones.filter(phone => phone.price >= 5000);
console.log(filterES6);


/* ReactDOM */
//  ReactDOM.render(template, root);