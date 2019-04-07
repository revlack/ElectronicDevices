import {
    CHANGE_LOADING, CHANGE_DEVICES
} from './DeviceTypes'
import { HttpGet } from '../../Functions/HttpRequests';

export const changeLoading = (action) => {    
    return (dispatch) => {
        dispatch({ type: CHANGE_LOADING, payload: action  });
    }
}

export const getDevicesByName = (name) => {
    if(name!== null && name!==""){
    return (dispatch) => {
            HttpGet(`site/device/getbyname?name=${name}`, null)
            .then(function (result) {
                dispatch({ type: CHANGE_DEVICES, payload: result.data.response });
            })
            .catch(function () {
               alert("An error occurred, please try later.");
            });
     } 
    }
}
