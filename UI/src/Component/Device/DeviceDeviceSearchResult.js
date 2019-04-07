import React, { Component } from 'react';

class DeviceDeviceSearchResult extends Component {
  render() {
    return (
        <React.Fragment>
         <div className="device-item">
         <h3>Product name: {this.props.Name}</h3>   
         <img className="device-image-loop" alt={this.props.Name} src={this.props.Url}></img><br/><br/>
         <span>Price: {this.props.Price.toFixed(2)}</span><br/><br/>
         <span>Category: {this.props.Category}</span><br/><br/>
         <span>{this.props.Description}</span><br/><br/>
         </div>
        </React.Fragment>
    );
  }
}

export default DeviceDeviceSearchResult;
