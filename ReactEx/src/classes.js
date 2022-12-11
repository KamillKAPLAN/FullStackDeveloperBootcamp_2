var ES5Person = function () {

}
/* nesne - object */
const es5P = new ES5Person();
console.log(es5P);

// ES6 Class
class ES6Person {
    /* nesne oluşturduğumuz anda çalışan yapıya constructor denir. */
    constructor(name = "Misafir", year = new Date().getFullYear()) {
        this.name = name;
        this.year = year;
        console.log("constructor çalıştı.")
    }

    /* metot     : eğer class'a hizmet ediyorsa 
       fonksiyon : kendi başına çalışıyorsa
     */
    calculateAge() {
        return new Date().getFullYear() - this.year;
    }

    greeting(text) {
        return `${text}, Benim adım ${this.name}`;
    }
}

/* nesne - object */
const es6p = new ES6Person();
const es6p2 = new ES6Person("Melih", 1996);
console.log(es6p, es6p.calculateAge(), es6p.greeting("Selam"));
console.log(es6p2, es6p2.calculateAge(), es6p2.greeting("Merhaba"));
