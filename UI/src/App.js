import React, { Component } from 'react';
import  {  createStore,  applyMiddleware  }  from  'redux';
import  {  Provider  }  from  'react-redux';
import  ReduxThunk  from  'redux-thunk';
import  reducers  from  './Reducer'
import Router from './Router';

class App extends Component {
  render() {
    return (
      <React.Fragment>
      <Provider store={createStore(reducers, {},  applyMiddleware(ReduxThunk))}>
        <Router />
        </Provider>
        </React.Fragment>
    );
  }
}

export default App;
