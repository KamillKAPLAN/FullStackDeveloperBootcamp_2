const root = document.getElementById("root");

class Header extends React.Component {
    render() {
        return (
            <>
                <h1>Todo Application</h1>
                <div>Lorem, ipsum.</div>
            </>
        );
    }
}

class TodoList extends React.Component {
    render() {
        return (
            <ul>
                <TodoItem />
                <TodoItem />
                <TodoItem />
            </ul>
        );
    }
}

class TodoItem extends React.Component {
    render() {
        return (
            <li>Lorem, ipsum.</li>
        );
    }
}

class Action extends React.Component {
    render() {
        return (
            <>
                <p>
                    <button>Clear Items</button>
                </p>
                <form>
                    <input type="text" name="txtItem" id="txtItem" />
                    <button type="submit">Add Item</button>
                </form>
            </>
        );
    }
}

class TodoApp extends React.Component {
    render() {
        return (
            <>
                <Header />
                <TodoList />
                <Action />
            </>
        );
    }
}

/* ReactDOM */
ReactDOM.render(<TodoApp />, root);