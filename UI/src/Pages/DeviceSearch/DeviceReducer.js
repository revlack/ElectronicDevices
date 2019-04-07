import {CHANGE_LOADING, CHANGE_DEVICES} from './DeviceTypes'

const INITIAL_STATE = {
    loading: false,
    devices:[]
}

const DeviceReducer = (state = INITIAL_STATE, action) => {
    switch (action.type) {
        case CHANGE_LOADING:   
            return { ...state, loading: action.payload };      
        case CHANGE_DEVICES:
            return { ...state, devices: action.payload };   
        default:
            return state;
    }
}

export default DeviceReducer;