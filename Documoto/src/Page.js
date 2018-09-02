import React, { Component } from 'react';
import Part from './Part';
import "./App.css";

class Page extends Component {
    constructor(props) {
        super(props);
        this.state = { viewText: this.props.viewText };
    }

    handleClick() {
        this.setState((state) => ({ viewText: !state.viewText }));
    }

    render() {
        return (
            <div className="Page">
                <a onClick={this.handleClick.bind(this)} title="click to see paragraphs">{this.props.page.name}</a>
                <ul>
                    {
                        this.state.viewText ? this.props.page.parts.map(part => <li key={part.id}><Part part={part}></Part></li>) : ''
                    }
                </ul>
            </div>
        );
    }
}

export default Page;
