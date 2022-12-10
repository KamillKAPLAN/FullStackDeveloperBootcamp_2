const root = document.getElementById("root");

/* ES5 */
var helloES5 = function () {
    console.log("Hello ES5");
}
function merhabaES5() {
    console.log("Merhaba ES5");
}
helloES5();
merhabaES5();

/* ES6 */
let helloES6 = () => {
    console.log("Hello ES6")
}
let merhabaES6 = () => console.log("Merhaba ES6");
helloES6();
merhabaES6();

let multiES6 = function (x, y) {
    return x * y;
}
let cokluES6 = (x, y) => { return x + y };
let coklu2ES6 = (x, y) => x - y;
console.log(multiES6(4, 5));
console.log(cokluES6(4, 5));
console.log(coklu2ES6(4, 5));

let getLessonES5 = function (id, lessonName) {
    return {
        id: id,
        name: lessonName
    }
}
let getLessonES6 = (id, lessonName) => {
    return {
        id: id,
        name: lessonName
    }
};
let getLesson2ES6 = (id, lessonName) => ({
    id: id,
    name: lessonName
});
console.log(getLessonES5(1, ".Net Core Web API"))
console.log(getLesson2ES6(2, "React"))

/* ReactDOM */
//  ReactDOM.render(template, root);