const root = document.getElementById("root");

var name = "Kamil ";
var name = "KAPLAN";
console.log(name);

/*let nameLet = "Kamil KAPLAN";
let nameLet = "Melih KAPLAN";
console.log(nameLet); */

/*const nameConst = "Kamil KAPLAN";
nameConst = "KAMİL";
const nameConst = "Melih KAPLAN";
console.log(nameConst); */

let age = 28;
function getAge() {
    let name = "Kamil";
    let age = 30;
    console.log("Function Scope : ", name, age);
}
getAge();

var city = "Malatya";
if(true) {
    var city = "İstanbul";
    console.log(city);
}
console.log(city);

let newCity = "Ankara";
if(true) {
    let newCity = "Antalya";
    console.log(newCity);
}
console.log(newCity);