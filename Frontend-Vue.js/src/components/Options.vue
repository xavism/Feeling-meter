<template>
  <div class="options">
    <div class="wrapper">
      <h1 class="title" v-html="data.title"></h1>
      <ul>
        <li v-tooltip.left="icon" v-for="(icon, index) in data.icons"><a @click="clickOption(icon, data.icons)" :class="'icon sentifont-'+icon+' '+colors[index]"></a></li>

      </ul>
    </div>
  </div>
</template>

<script>
import _ from 'lodash'
import $ from 'jquery'
const colors = ["green","orange","red"]
export default {
  name: 'options',
  props: ['data', 'value'],
  data() {
    return {
      colors: colors
    }
  },
  methods: {
    clickOption: function (icon, icons) {
      //this.$emit('choose');
      this.value.status = true;
      this.value.selection = icon
      _.forEach(icons, function(value) {
        var $input = $('.sentifont-'+value);
        if (value == icon) $input.addClass('rounded-border');
        else $input.removeClass('rounded-border');
      });
    }
  }
}


</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
 .options {
   min-height: 100vh;
   display: flex;
   justify-content: center;
   align-items: center;
   color: white;
 }

 h1 {
   color: white;
 }

 a {
  color: white;
  font-size: 100px;
  padding: 60px;
  margin: 10px;
  border-width: 4px;
  border-radius: 50%;
 }
a {
  background: rgba(255,255,255,0.1);
  -webkit-transition: -webkit-transform ease-out 0.1s, background 0.2s;
  -moz-transition: -moz-transform ease-out 0.1s, background 0.2s;
  transition: transform ease-out 0.1s, background 0.2s;
}
.green:hover {
  color: #23d160;
}
.green{
  border-color: #23d160;
}


.orange:hover {
  color: #ffdd57;
}
.orange {
  border-color: #ffdd57;
}

.red:hover {
  color: #ff3860;
}
.red {
  border-color: #ff3860;
}

.rounded-border {
  border-width: 4px;
  border-style: solid;
}

a:after {
  top: 0;
  left: 0;
  padding: 0;
  z-index: -1;
  box-shadow: 0 0 0 2px rgba(255,255,255,0.1);
  opacity: 0;
  -webkit-transform: scale(0.9);
  -moz-transform: scale(0.9);
  -ms-transform: scale(0.9);
  transform: scale(0.9);
}

a:hover {
  background: rgba(255,255,255,0.05);
  -webkit-transform: scale(0.93);
  -moz-transform: scale(0.93);
  -ms-transform: scale(0.93);
  transform: scale(0.93);
  color: #fff;
}

a:hover:after {
  -webkit-animation: sonarEffect 1.3s ease-out 75ms;
  -moz-animation: sonarEffect 1.3s ease-out 75ms;
  animation: sonarEffect 1.3s ease-out 75ms;
}

@-webkit-keyframes sonarEffect {
  0% {
    opacity: 0.3;
  }
  40% {
    opacity: 0.5;
    box-shadow: 0 0 0 2px rgba(255,255,255,0.1), 0 0 10px 10px #3851bc, 0 0 0 10px rgba(255,255,255,0.5);
  }
  100% {
    box-shadow: 0 0 0 2px rgba(255,255,255,0.1), 0 0 10px 10px #3851bc, 0 0 0 10px rgba(255,255,255,0.5);
    -webkit-transform: scale(1.5);
    opacity: 0;
  }
}
@-moz-keyframes sonarEffect {
  0% {
    opacity: 0.3;
  }
  40% {
    opacity: 0.5;
    box-shadow: 0 0 0 2px rgba(255,255,255,0.1), 0 0 10px 10px #3851bc, 0 0 0 10px rgba(255,255,255,0.5);
  }
  100% {
    box-shadow: 0 0 0 2px rgba(255,255,255,0.1), 0 0 10px 10px #3851bc, 0 0 0 10px rgba(255,255,255,0.5);
    -moz-transform: scale(1.5);
    opacity: 0;
  }
}
@keyframes sonarEffect {
  0% {
    opacity: 0.3;
  }
  40% {
    opacity: 0.5;
    box-shadow: 0 0 0 2px rgba(255,255,255,0.1), 0 0 10px 10px #3851bc, 0 0 0 10px rgba(255,255,255,0.5);
  }
  100% {
    box-shadow: 0 0 0 2px rgba(255,255,255,0.1), 0 0 10px 10px #3851bc, 0 0 0 10px rgba(255,255,255,0.5);
    transform: scale(1.5);
    opacity: 0;
  }
}


</style>