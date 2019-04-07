import React, { Component } from 'react';
import DinamicMessage from '../Component/DinamicMessage'
import LayoutInternal from '../Layout/Layout'

class Home extends Component {
  render() {
    return (
        <React.Fragment>
         <LayoutInternal>
             <DinamicMessage/>  
         </LayoutInternal>  
          </React.Fragment>
    );
  }
}

export default Home;
