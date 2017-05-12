import Vue from 'vue'
import Router from 'vue-router'
import axios from 'axios'
import VueAxios from 'vue-axios'

import Sentimetro from '@/containers/Sentimetro'
import Done from '@/containers/Done'
import VTooltip from 'v-tooltip'

Vue.use(VTooltip)
Vue.use(Router)
Vue.use(VueAxios, axios)
export default new Router({
  routes: [
    {
      path: '/',
      name: 'Sentimetro',
      component: Sentimetro
    },
    {
      path: '/done',
      name: 'Done',
      component: Done
    }
  ],
  mode: 'history'
})
