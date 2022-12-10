var root = document.getElementById("root");

var number = 0;

function artiBir() { console.log("arti bir"); }

var eksiBir = () => { console.log("eksi bir"); }

var template = (
    <>
        <h1>Number : {number}</h1>
        <button id="btnArti" onClick={artiBir}>+1</button>
        <button id="btnArti" onClick={eksiBir}>-1</button>
        <button id="btnArti" onClick={
            () => {
                console.log("sıfırlandı");
            }
        }>Reset</button>
    </>
);

/* ReactDOM */
ReactDOM.render(template, root);