var root = document.getElementById("root");

function tick() {
    var element = (
        <>
            <h2>Saat : {new Date().toLocaleTimeString()}</h2>
        </>
    );

    /* ReactDOM */
    ReactDOM.render(element, root);
}

setInterval(tick, 1000);