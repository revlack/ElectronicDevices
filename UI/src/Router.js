
import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { connect } from 'react-redux';
import Home  from './Pages/Home';
import DeviceSearchPage from './Pages/DeviceSearch/DeviceSearchPage';

class Router extends Component {
    render() {
            return (
                <span>                  
                        <BrowserRouter>
                            <Switch>
                                <Route exact path='/' component={Home} />
                                <Route exact path='/DeviceSearch' component={DeviceSearchPage} />
                              </Switch>
                        </BrowserRouter>
                 </span>
            );    
      }
}

const mapStateToProps = state => {
    return {
    }
};

export default connect(mapStateToProps, null)(Router);