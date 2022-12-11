import React, { Component } from 'react'

export default class Section extends Component {
    render() {
        return (
            <section class="py-5 text-center container">
                <div class="row py-lg-5">
                    <div class="col-lg-6 col-md-8 mx-auto">
                        <h1 class="fw-light">Album example</h1>
                        <h1 class="lead text-muted"><b>React Router</b> : https://www.w3schools.com/react/react_router.asp</h1>
                        <h2 class="lead text-muted"><b>React Js Axios</b>https://erolakgul.net/2021/11/03/react-js-notlari/</h2>
                        <h1 class="lead text-muted"><b>Axios : </b> https://www.freecodecamp.org/news/how-to-perform-crud-operations-using-react/</h1>
                        <h1 class="lead text-muted"><b>Axios : </b> https://www.javaguides.net/2020/08/reactjs-axios-get-post-put-and-delete-example-tutorial.html</h1>
                        <p class="lead text-muted">Something short and leading about the collection below—its contents, the
                            creator, etc. Make it short and sweet, but not too short so folks don’t simply skip over it
                            entirely.</p>
                        <p>
                            <a href="#" class="btn btn-primary my-2">Main call to action</a>
                            <a href="#" class="btn btn-secondary my-2">Secondary action</a>
                        </p>
                    </div>
                </div>
            </section>
        )
    }
}
