import React, { Component } from 'react';
import Part from './Part';
import "./App.css";

/* eslint no-undef: "off"*/
class Employee extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className="Parts">
                <ul>
                    {this.props.employee.dependents.map(part => <li><Part part={part} saveCallback={this.props.saveCallback}></Part></li>)}

                </ul>
            </div>
        );
    }
}

export default Employee;
