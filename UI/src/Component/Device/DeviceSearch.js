import React, { Component } from 'react';

class DeviceSearch extends Component {
 
  constructor(props){    
        super(props)
        this.state = {
            value: ""
         };
  }

  handleAlteraNomeCondutor = (event) =>{
    if (event.target.value !== null) {
        this.setState({value:event.target.value});
    }
    
  }
  render() {
    return (
        <React.Fragment>
            <input type="text" className="searchBar"  onChange={this.handleAlteraNomeCondutor} value={this.state.value}></input>
            <button type="Buttom" className="buttonBar" onClick={()=>this.props.handleClick(this.state.value)}>SEARCH</button>
        </React.Fragment>
    );
  }
}

export default DeviceSearch;
