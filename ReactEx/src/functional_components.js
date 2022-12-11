/* Function  : STATE X yok, onun yerine Hook
   Component : STATE + var
 */
   const root = document.getElementById("root");

   function Header(props) {
       return (
           <>
               <h1>Todo Application</h1>
               <div>Lorem, ipsum.</div>
           </>
       )
   }
   
   const Header2 = (props) => {
       return (
           <>
               <h1>Todo Application1</h1>
               <div>Lorem ipsum dolor sit amet.</div>
           </>
       )
   }
   
   function TodoApp() {
       return (
           <>
               <Header />
           </>
       )
   }
   /* ReactDOM */
   ReactDOM.render(<TodoApp />, root);