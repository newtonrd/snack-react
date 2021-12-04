import React, { Component } from 'react';
import { Route } from 'react-router';
import About from './routes/about';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter  from './components/Counter';
import { FetchData } from './components/Snack';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/snack' component={FetchData} />
        <Route path='/about' component={About} />
      </Layout>
    );
  }
}
