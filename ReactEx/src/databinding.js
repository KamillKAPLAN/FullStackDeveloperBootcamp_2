var root = document.getElementById("root");

var number = 0;

function artiBir() { number++; renderApp(); console.log("arti bir"); }

var eksiBir = () => { number--; renderApp(); console.log("eksi bir"); }

function renderApp() {
    var template = (
        <>
            <h1>Number : {number}</h1>
            <button id="btnArti" onClick={artiBir}>+1</button>
            <button id="btnArti" onClick={eksiBir}>-1</button>
            <button id="btnArti" onClick={
                () => {
                    number != 0 ? number = 0 : alert("Number değeri sıfır'dır");
                    renderApp();
                    console.log("sıfırlandı");
                }
            }>Reset</button>
        </>
    );

    /* ReactDOM */
    ReactDOM.render(template, root);
}

renderApp();