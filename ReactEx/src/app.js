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
    }

    render() {
        console.log("TodoList Props : ", this.props)
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
                            <TodoItem deleteItem={this.props.deleteItem} key={index} item={item} />
                        )
                    }
                </ul>
                <p>
                    <button onClick={this.props.clearItems}>Clear Items</button>
                </p>
            </>
        );
    }
}

class TodoItem extends React.Component {
    constructor(props) {
        super(props);
        this.deleteItem = this.deleteItem.bind(this);
    }

    deleteItem() {
        this.props.deleteItem(this.props.item)
    }
    render() {
        console.log("TodoItem Props : ", this.props.item)
        return (
            <li>
                {this.props.item} 
                <button onClick={this.deleteItem}>X</button>
            </li>
        );
    }

    /* EKLEME */
    componentDidMount() {
        console.log("component ekleme işlemi");
    }
    /* GÜNCELLEME */
    componentDidUpdate() {
        console.log("component güncelleme işlemi");
    }
    /* SİLME */
    componentWillUnmount() {
        console.log("component kaldırıldı işlemi");
    }
}

class Action extends React.Component {
    constructor(props) {
        super(props);
        this.onFormSubmit = this.onFormSubmit.bind(this);
        this.state = {
            err: ""
        }
    }

    onFormSubmit(event) {
        event.preventDefault();

        const item = event.target.elements.txtItem.value.trim();
        /* addItem */
        const error = this.props.addItem(item);
        this.setState({
            err: error
        })
        event.target.elements.txtItem.value = "";
    }

    render() {
        return (
            <>
                {this.state.err && <p>{this.state.err}</p>}
                <form onSubmit={this.onFormSubmit}>
                    <input type="text" name="txtItem" id="txtItem" />
                    <button type="submit">Add Item</button>
                </form>
            </>
        );
    }  
}

class TodoApp extends React.Component {
    constructor(props) {
        super(props);
        /* clearItems */
        this.clearItems = this.clearItems.bind(this);
        /* addItem */
        this.addItem = this.addItem.bind(this);
        /* deleteItem */
        this.deleteItem = this.deleteItem.bind(this);
        this.state = {
            items: ["item 1", "item 2", "item 3", "item 4", "item 5", "item 6", "item 7", "item 8"]
        }
    }
    clearItems() {
        console.log("Clear Items TodoApp : ");
        this.setState({
            items: []
        })
    }
    addItem(item) {
        if (!item) {
            return "eklemek istediğiniz elamını giriniz";
        } else if (this.state.items.indexOf(item) > -1) {
            return "aynı elemanı ekleyemezsiniz";
        }
        this.setState((prevState) => {
            return { items: prevState.items.concat(item) }
        })
    }
    deleteItem(item) {
        this.setState((prevState) => {
            const arr = prevState.items.filter((i) => {
                return item != i;
            })
            return {
                items: arr
            }
        })
    }

    render() {
        const title = "Todo Application !";
        const description = "Lorem ipsum dolor sit amet consectetur adipisicing.";
        var app = {
            title: "Todo Application !!!",
            description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit?",
        }

        return (
            <>
                {/* <Header title="Todo Application" description="Lorem ipsum dolor sit." /> */}
                {/* <Header title={title} description={description} /> */}
                <Header title={app.title} description={app.description} />
                <TodoList deleteItem={this.deleteItem} items={this.state.items} clearItems={this.clearItems} />
                <Action addItem={this.addItem} />
            </>
        );
    }    
}

/* ReactDOM */
ReactDOM.render(<TodoApp />, root);