import axios from 'axios'
import { baseUrl, token } from '../Config/Consts'

const instance = axios.create({
    baseURL: baseUrl
});

export const HttpGet = async (urlApi, param = null) => {
    return await InternalHttpGet(urlApi, param)
        .then(function (data) {
            return data;
        });
}

const InternalHttpGet = async (urlApi, param = null) => {

    instance.defaults.headers.common['Authorization'] = token;
    
    return await instance.get(urlApi, param)
}
