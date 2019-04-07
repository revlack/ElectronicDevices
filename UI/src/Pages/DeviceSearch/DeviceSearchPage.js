import React, { Component } from 'react';
import LayoutInternal from '../../Layout/Layout'
import ElectronicDeviceSearch from '../../Component/Device/DeviceSearch'
import DeviceDeviceSearchResult from '../../Component/Device/DeviceDeviceSearchResult'
import {getDevicesByName} from './DeviceActions'
import { connect } from 'react-redux';

class DeviceSearchPage extends Component {

  
  render() {    
  let listDevice = [];

  this.props.Devices.forEach(function(element) {
    listDevice.push(
      <DeviceDeviceSearchResult key={element.deviceId} Name={element.name} 
      Url={element.imageUrl} Price={element.price} Description={element.description} Category = {element.category} />
    );
  });  


    return (       
        <React.Fragment>       
         <LayoutInternal>
           <h1>Electronic Devices Search</h1>
           <ElectronicDeviceSearch handleClick={this.props.getDevicesByName}/>         
           <div className="loop-device">{listDevice}</div>
         </LayoutInternal>  
        </React.Fragment>
    );
  }
}

const mapStateToProps = state => {
  return {
      Devices: state.searchPage.devices,
      Loading: state.searchPage.loading
  }
};

export default connect(mapStateToProps, 
  {getDevicesByName}
  )(DeviceSearchPage)

