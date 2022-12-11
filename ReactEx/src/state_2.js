const root = document.getElementById("root");

class Counter extends React.Component {

    constructor(props) {
        super(props);
        this.artiBir = this.artiBir.bind(this);
        this.eksiBir = this.eksiBir.bind(this);
        this.reset = this.reset.bind(this);
        this.state = { number: 0 }
    }

    artiBir() { this.setState({ number: this.state.number + 1 }) }
    eksiBir() { this.setState((prevState) => { return { number: prevState.number - 1 } }) }
    reset() { this.setState({ number: 0 }) }

    render() {
        return (
            <>
                <h1>Number : {this.state.number}</h1>
                <button onClick={this.artiBir}>+1</button>
                <button onClick={this.eksiBir}>-1</button>
                <button onClick={this.reset}>Reset</button>
            </>
        )
    }
}

/* ReactDOM */
ReactDOM.render(<Counter />, root);