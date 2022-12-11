class Insan {
    constructor(name = "Misafir", year = new Date().getFullYear()) {
        this.name = name;
        this.year = year;
        console.log("Insan constructor çalıştı.");
    }

    calculateAge() {
        return new Date().getFullYear() - this.year;
    }
    greeting(text) {
        return `${text}, Benim adım ${this.name}`;
    }
}

class Ogretmen extends Insan {
    constructor(name, year, department) {
        super(name, year);
        this.department = department;
        console.log("Öğretmen constructor çalıştı.");
    }

    teach() {
        return "Öğretiyorum";
    }
    greeting(text) {
        return `${text}, Benim adım ${this.name}. Departmanım : ${this.department}`;
    }
}

class Ogrenci extends Insan {
    constructor(name, year, studentNumber) {
        super(name, year);
        this.studentNumber = studentNumber;
        console.log("Öğrenci constructor çalıştı.");
    }

    study() {
        return "Öğreniyorum";
    }
    greeting(text) {
        let str = super.greeting();
        str += ` Numaram : ${this.studentNumber}`;
        return str;
    }
}

const oI = new Ogretmen("Kamil", 1994, "Yazılım");
console.log(oI, oI.calculateAge(), oI.greeting("Merhaba"), oI.teach());

const ogrI = new Ogrenci("Melih", 1996, 14542025);
console.log(ogrI, ogrI.calculateAge(), ogrI.greeting("Selam"), ogrI.study());

const i = new Insan("Burak", 1992);
console.log(i, i.calculateAge(), i.greeting("Merhaba"));