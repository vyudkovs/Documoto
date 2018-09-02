import React, { Component } from 'react';
import "./App.css";
import { DAL } from './DAL';
import config from './config';

/* eslint no-undef: "off"*/
class Translation extends Component {
    constructor(props) {
        super(props);
        this.state = { words: '' };
        this.dal = new DAL(config);
    }

    componentWillMount() {
        this.dal.GetTranslation(this.props.id).then(response => {
            return response.json();
        })
        .catch((error) => {
            console.log(error)
        })
        .then(result => {
            this.setState({ words: result.words });
        })
    }

    render() {
        return (
            <div className="Translation">
                {this.state.words}
            </div>
        );
    }
}

export default Translation;
