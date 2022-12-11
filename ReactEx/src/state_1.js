const root = document.getElementById("root");

class Car extends React.Component {
    constructor(props) {
        super(props);
        this.changeColor = this.changeColor.bind(this)
        this.state = {
            brand: "Opel",
            model: "Astra",
            color: "red",
            year: 2020
        }
    }
    
    changeColor() {
        console.log(this);
        /* this.state.color = "YELLOW"; */
        this.setState({
            color: "YELLOW",
            model: "Corsa"
        })
    }
    render() {
        return (
            <>
                <h1>{this.state.brand} - {this.state.model}</h1>
                <p>Selected Color : {this.state.color}</p>
                <button onClick={this.changeColor}>Change Color</button>
            </>
        );
    }
}

/* ReactDOM */
ReactDOM.render(<Car />, root);