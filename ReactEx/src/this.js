const root = document.getElementById("root");

const user = {
    fullName: "Kamil KAPLAN",
    email: "kamilkaplnn@gmail.com",
    city: "İstanbul",
    roles: ["admin", "customer"],

    getRoles: function () {
        console.log(this.fullName);
        console.log(this.roles);

        /* ES5 */
        this.roles.forEach(function (role) {
            console.log(role);
        });

        /* ES6 */
        this.roles.forEach((role) => console.log(role));
    }
}
console.log("UserName : " + user.fullName);
user.getRoles();

const totalES5 = function () {
    console.log(arguments); // sadece ES5
    let total = 0;
    for (let index = 0; index < arguments.length; index++) {
        total += arguments[index];
    }
    return total;
}

console.log("Toplam : " + totalES5(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

/* ReactDOM */
//  ReactDOM.render(template, root);