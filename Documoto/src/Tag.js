import React, { Component } from 'react';
import "./App.css";

/* eslint no-undef: "off"*/
class Employee extends Component {
    constructor(props) {
        super(props);
        this.state = { tag: props.tag, isHiddenWritable: true }
    }
    render() {
        return (
            <div className="Tag">
                <span onClick={this.handleClick.bind(this)}>{this.state.tag.firstName} {this.state.tag.lastName}</span>
                {!this.state.isHiddenWritable &&
                    <div>
                    <a onclick={this.props.searchByTag}>{this.state.tag.Name}</a>
                    </div>
                }
            </div>
        );
    }
}

export default Employee;
