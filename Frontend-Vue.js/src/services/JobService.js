import Vue from 'vue'
import { apiRoute } from './../data/routesDev.js'
export default {
    get() {
        return Vue.axios.get(apiRoute + '/votes');
    },
    create(data) {
        return Vue.axios.post(apiRoute + '/votes', data)
    }
}