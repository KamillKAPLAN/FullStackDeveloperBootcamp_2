"use strict";

function _typeof(obj) { "@babel/helpers - typeof"; return _typeof = "function" == typeof Symbol && "symbol" == typeof Symbol.iterator ? function (obj) { return typeof obj; } : function (obj) { return obj && "function" == typeof Symbol && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }, _typeof(obj); }
function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }
function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, _toPropertyKey(descriptor.key), descriptor); } }
function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); Object.defineProperty(Constructor, "prototype", { writable: false }); return Constructor; }
function _toPropertyKey(arg) { var key = _toPrimitive(arg, "string"); return _typeof(key) === "symbol" ? key : String(key); }
function _toPrimitive(input, hint) { if (_typeof(input) !== "object" || input === null) return input; var prim = input[Symbol.toPrimitive]; if (prim !== undefined) { var res = prim.call(input, hint || "default"); if (_typeof(res) !== "object") return res; throw new TypeError("@@toPrimitive must return a primitive value."); } return (hint === "string" ? String : Number)(input); }
function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); Object.defineProperty(subClass, "prototype", { writable: false }); if (superClass) _setPrototypeOf(subClass, superClass); }
function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf ? Object.setPrototypeOf.bind() : function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }
function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }
function _possibleConstructorReturn(self, call) { if (call && (_typeof(call) === "object" || typeof call === "function")) { return call; } else if (call !== void 0) { throw new TypeError("Derived constructors may only return object or undefined"); } return _assertThisInitialized(self); }
function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }
function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Boolean.prototype.valueOf.call(Reflect.construct(Boolean, [], function () {})); return true; } catch (e) { return false; } }
function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf.bind() : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }
var root = document.getElementById("root");
/* https://medium.com/kodcular/reactjs-state-nedir-class-componentlerinde-nas%C4%B1l-kullan%C4%B1l%C4%B1r-68694a9e0173 */
var Header = /*#__PURE__*/function (_React$Component) {
  _inherits(Header, _React$Component);
  var _super = _createSuper(Header);
  function Header() {
    _classCallCheck(this, Header);
    return _super.apply(this, arguments);
  }
  _createClass(Header, [{
    key: "render",
    value: function render() {
      console.log("Header Props : ", this.props);
      return /*#__PURE__*/React.createElement(React.Fragment, null, /*#__PURE__*/React.createElement("h1", null, this.props.title), /*#__PURE__*/React.createElement("div", null, this.props.description));
    }
  }]);
  return Header;
}(React.Component);
var TodoList = /*#__PURE__*/function (_React$Component2) {
  _inherits(TodoList, _React$Component2);
  var _super2 = _createSuper(TodoList);
  /* Uncaught TypeError: Cannot read properties of undefined (reading 'props') ÇÖZÜM */
  function TodoList(props) {
    var _this;
    _classCallCheck(this, TodoList);
    _this = _super2.call(this, props);
    _this.clearItems = _this.clearItems.bind(_assertThisInitialized(_this));
    return _this;
  }
  _createClass(TodoList, [{
    key: "clearItems",
    value: function clearItems() {
      console.log(this);
      console.log("Clear Items : ", this.props.items);
    }
  }, {
    key: "render",
    value: function render() {
      console.log("TodoList Props : ", this.props.items);
      return /*#__PURE__*/React.createElement(React.Fragment, null, /*#__PURE__*/React.createElement("ul", null,
      /*
      this.props.items.map((item, index) =>
          <li key={index}>{item}</li>
      ) */
      this.props.items.map(function (item, index) {
        return /*#__PURE__*/React.createElement(TodoItem, {
          key: index,
          item: item
        });
      })), /*#__PURE__*/React.createElement("p", null, /*#__PURE__*/React.createElement("button", {
        onClick: this.clearItems
      }, "Clear Items")));
    }
  }]);
  return TodoList;
}(React.Component);
var TodoItem = /*#__PURE__*/function (_React$Component3) {
  _inherits(TodoItem, _React$Component3);
  var _super3 = _createSuper(TodoItem);
  function TodoItem() {
    _classCallCheck(this, TodoItem);
    return _super3.apply(this, arguments);
  }
  _createClass(TodoItem, [{
    key: "render",
    value: function render() {
      console.log("TodoItem Props : ", this.props.item);
      return /*#__PURE__*/React.createElement("li", null, this.props.item);
    }
  }]);
  return TodoItem;
}(React.Component);
var Action = /*#__PURE__*/function (_React$Component4) {
  _inherits(Action, _React$Component4);
  var _super4 = _createSuper(Action);
  function Action(props) {
    _classCallCheck(this, Action);
    return _super4.call(this, props);
  }
  _createClass(Action, [{
    key: "onFormSubmit",
    value: function onFormSubmit(event) {
      event.preventDefault();
      var item = event.target.elements.txtItem.value.trim();
      if (item) {
        console.log(item);
        event.target.elements.txtItem.value = "";
      }
    }
  }, {
    key: "render",
    value: function render() {
      return /*#__PURE__*/React.createElement(React.Fragment, null, /*#__PURE__*/React.createElement("form", {
        onSubmit: this.onFormSubmit
      }, /*#__PURE__*/React.createElement("input", {
        type: "text",
        name: "txtItem",
        id: "txtItem"
      }), /*#__PURE__*/React.createElement("button", {
        type: "submit"
      }, "Add Item")));
    }
  }]);
  return Action;
}(React.Component);
var TodoApp = /*#__PURE__*/function (_React$Component5) {
  _inherits(TodoApp, _React$Component5);
  var _super5 = _createSuper(TodoApp);
  function TodoApp() {
    _classCallCheck(this, TodoApp);
    return _super5.apply(this, arguments);
  }
  _createClass(TodoApp, [{
    key: "render",
    value: function render() {
      var title = "Todo Application !";
      var description = "Lorem ipsum dolor sit amet consectetur adipisicing.";
      var app = {
        title: "Todo Application !!!",
        description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit?",
        items: ["item 1", "item 2", "item 3", "item 4"]
      };
      return /*#__PURE__*/React.createElement(React.Fragment, null, /*#__PURE__*/React.createElement(Header, {
        title: app.title,
        description: app.description
      }), /*#__PURE__*/React.createElement(TodoList, {
        items: app.items
      }), /*#__PURE__*/React.createElement(Action, null));
    }
  }]);
  return TodoApp;
}(React.Component);
/* ReactDOM */
ReactDOM.render( /*#__PURE__*/React.createElement(TodoApp, null), root);
