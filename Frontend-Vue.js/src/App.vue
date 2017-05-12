<template>
  <div id="app">
    <div class="app">
      <section class="hero is-fullheight">
        <router-view></router-view>
      </section>
    </div>
  </div>
</template>

<script>
import 'bulma'
import $ from 'jquery'

export default {
  name: 'app'
}
</script>

<style lang="css">
.app {
     background-image: linear-gradient(rgba(0, 209, 179, 0.4),rgba(140, 0, 210, 0.4)),linear-gradient(rgba(0, 0, 0, 0.6),rgba(0, 0, 0, 0.6)), url(/static/Background-Monkey.jpg);
    -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover;
}
.hero {
    background-color: transparent !important;
    position: relative;
}

#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  text-align: center;
  color: #2c3e50;
  margin: 0;
  padding: 0;
}

body, html {
  margin: 0px;
  padding: 0px;
}
*::-webkit-scrollbar { 
    display: none; 
}


.no-js #loader { display: none;  }
.js #loader { display: block; position: absolute; left: 100px; top: 0; }
.se-pre-con {
	position: fixed;
	left: 0px;
	top: 0px;
	width: 100%;
	height: 100%;
	z-index: 9999;
	background: url(/static/Preloader.gif) center no-repeat #fff;
}

* {
  font-family: 'Josefin Sans', sans-serif;
}

.tooltip.vue-tooltip-theme {
  background-color: rgba(0,0,0,0.5);
  color: white;
  padding: 5px 15px;
  border-radius: 5px;
  font-size: 30px;
}


</style>
