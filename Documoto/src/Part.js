import React, { Component } from 'react';
import Translation from './Translation';
import "./App.css";

/* eslint no-undef: "off"*/
class Part extends Component {
    constructor(props) {
        super(props);
        this.state = {showTranslation: false};
    }

    handleClick() {
        this.setState((state) => ({ showTranslation: !state.showTranslation }));
    }

    render() {
        return (
            <div className="Part">
                <a onClick={this.handleClick.bind(this)} title={!this.state.showTranslation ? 'click to translate' : ' click to hide translation'}>{this.props.part.words}</a>
                {this.state.showTranslation ? <Translation id={this.props.part.id}>test</Translation> : ''}
            </div>
        );
    }
}

export default Part;
