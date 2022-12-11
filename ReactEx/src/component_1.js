const root = document.getElementById("root");

/* ES5 */
/*
const Header = function () {
    return <h1>Merhaba ben Kamil KAPLAN.</h1>;
}
var template = <Header />; 
*/

class Header extends React.Component {
    render() {
        /* return <h1>Merhaba ben Kamil</h1>; */
        return (
            <>
                <h1>Todo Application</h1>
                <div>Lorem, ipsum.</div>
            </>
        );
    }
}

/*var template = (
    <>
        <Header />
        <Header />
        <Header />
        <Header />
        <Header />
    </>
);*/

class Todo extends React.Component {
    render() {
        return (
            <>
                <ul>
                    <li>Lorem, ipsum.</li>
                    <li>Lorem, ipsum dolor.</li>
                    <li>Lorem ipsum dolor sit.</li>
                </ul>
            </>
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

var template = (
    <>
        <Header />
        <Todo />
        <Action />
    </>
);

/*
import React, { Component } from 'react'

export default class app extends Component {
  render() {
    return (
      <div>app</div>
    )
  }
} 
*/


/* ReactDOM */
ReactDOM.render(template, root);