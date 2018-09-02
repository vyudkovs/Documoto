import React, { Component } from 'react';
import "./App.css";
import Page from './Page';
import { DAL } from './DAL';
import config from './config';

/* eslint no-undef: "off"*/
class Pages extends Component {
    constructor() {
        super();
        this.state = { search: '', pages: [] };
        this.dal = new DAL(config);
    }

    GetPages(search) {
        this.dal.SearchPages(search).then(response => {
            return response.json();
        })
        .catch((error) => {
            console.log(error)
        })
        .then(pages => {
            this.setState({ pages: Array.isArray(pages) ? pages : [pages] });
        });
    }

    componentWillMount() {
        this.GetPages('');
    }

    handleSearch = (e) => {
        let search = e.target.value;
        this.setState(() => ({ search: search }));
        this.GetPages(e.target.value);
    }

    render() {
      return (
          <div className="Pages">
              <input type="search" value={this.state.search} onChange={this.handleSearch.bind(this)} />
              <ul>
                  {this.state.pages.map(page => 
                    page == null ? 'No Results' :
                    <li key={page.id || 0} >
                        <p />
                        <Page page={page} viewText={false}></Page>
                    </li>
                  )}
              </ul>
        </div>
    );
  }
}

export default Pages;
 