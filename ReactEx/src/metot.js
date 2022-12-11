const root = document.getElementById("root");
/* https://medium.com/kodcular/reactjs-state-nedir-class-componentlerinde-nas%C4%B1l-kullan%C4%B1l%C4%B1r-68694a9e0173 */
class Header extends React.Component {
    render() {
        console.log("Header Props : ", this.props)
        return (
            <>
                {/* <h1>Todo Application</h1>
                <div>Lorem, ipsum.</div> */}
                <h1>{this.props.title}</h1>
                <div>{this.props.description}</div>
            </>
        );
    }
}

class TodoList extends React.Component {
    /* Uncaught TypeError: Cannot read properties of undefined (reading 'props') ÇÖZÜM */
    constructor(props) {
        super(props);
        this.clearItems = this.clearItems.bind(this);
    }

    clearItems() {
        console.log(this)
        console.log("Clear Items : ", this.props.items);
    }

    render() {
        console.log("TodoList Props : ", this.props.items)
        return (
            <>
                <ul>
                    {/* 
                       <TodoItem />
                       <TodoItem />
                       <TodoItem /> */
                    }
                    {
                        /*
                        this.props.items.map((item, index) =>
                            <li key={index}>{item}</li>
                        ) */
                        this.props.items.map((item, index) =>
                            <TodoItem key={index} item={item} />
                        )
                    }
                </ul>
                <p>
                    <button onClick={this.clearItems}>Clear Items</button>
                </p>
            </>
        );
    }
}

class TodoItem extends React.Component {
    render() {
        console.log("TodoItem Props : ", this.props.item)
        return (
            <li>{this.props.item}</li>
        );
    }
}

class Action extends React.Component {
    constructor(props) {
        super(props);
    }

    onFormSubmit(event) {
        event.preventDefault();

        const item = event.target.elements.txtItem.value.trim();
        if (item) {
            console.log(item);
            event.target.elements.txtItem.value = "";
        }
    }

    render() {
        return (
            <>
                <form onSubmit={this.onFormSubmit}>
                    <input type="text" name="txtItem" id="txtItem" />
                    <button type="submit">Add Item</button>
                </form>
            </>
        );
    }
}

class TodoApp extends React.Component {
    render() {
        const title = "Todo Application !";
        const description = "Lorem ipsum dolor sit amet consectetur adipisicing.";
        var app = {
            title: "Todo Application !!!",
            description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit?",
            items: ["item 1", "item 2", "item 3", "item 4"]
        }

        return (
            <>
                {/* <Header title="Todo Application" description="Lorem ipsum dolor sit." /> */}
                {/* <Header title={title} description={description} /> */}
                <Header title={app.title} description={app.description} />
                <TodoList items={app.items} />
                <Action />
            </>
        );
    }
}

/* ReactDOM */
ReactDOM.render(<TodoApp />, root);