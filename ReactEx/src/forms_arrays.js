var root = document.getElementById("root");

var app = {
    title: "Todo Application",
    description: "Lorem, ipsum.",
    items: ["item1", "item2", "item3", "item4"]
};

var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var itemList = numbers.map(number =>
    <li key={number.toString()}>{number}</li>
);


function onFormSubmit(event) {
    event.preventDefault();
    var item = event.target.elements.txtItem.value;
    if (item) {
        app.items.push(item);
        event.target.elements.txtItem.value = "";
        render();
    }
    console.log(app.items)
}

function clearItems() {
    app.items = [];
    render();
}

function render() {
    var template2 = (
        <>
            <ul>
                <li>Arda Şen</li>
                <li>Koral Sancak</li>
                <li>Burak Özyolu</li>
                <li>Sertaç Bağcı</li>
                <li>Emine Can</li>
            </ul>
        </>
    );

    var template = (
        <>
            <div>{app.title}</div>
            <div>{app.description}</div>
            {
                // [10, 20, 30]
                // [<p key="10">10</p>, <p key="20">20</p>, <p key="30">30</p>]
                // <ul>{itemList}</ul>
                <ul>
                    {
                        /* Arrow Function */
                        app.items.map((item, index) => {
                            return <li key={index}>{item}</li>
                        })
                    }
                </ul>
            }
            <p>
                <button onClick={clearItems}>Clear Items</button>
            </p>
            <p>Item Length : {app.items.length}</p>
            <form onSubmit={onFormSubmit}>
                <input type="text" name="txtItem" id="txtItem" />
                <button type="submit">Add Item</button>
            </form>
        </>
    );

    /* ReactDOM */
    ReactDOM.render(template, root);
}
render();