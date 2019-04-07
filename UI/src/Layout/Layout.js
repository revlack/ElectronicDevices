import React, { Component } from 'react';
import '../App.css';
export default class LayoutInternal extends Component {
    render() {
        return (
            <div className="App">
            <header className="App-header">
                    {this.props.children}
             </header>               
            </div>
        )
    }
}


