<template>
      <div>
        <brand class="brand"></brand>
        <div v-on:loadResponse="show()" class="hero-body">
        
          <div class="container">
            <h1 class="title">
            <span class="icon is-large red">
                <i class="fa fa-hand-peace-o"></i>
              </span>
            </h1>
            <h1 class="title">
            <span class="green">Done!</span> Thank you for your feedback
            </h1>
            <h2 class="subtitle">
              Information has been sent succesfully!
              <span class="icon green">
                <i class="fa fa-smile-o"></i>
              </span>
            </h2>
            <router-link to="/" tag="a" class="button is-primary is-outlined">Go Back</router-link>
          </div>
        </div>
      </div>
</template>

<script>
import $ from 'jquery'
import router from './../router'
import "../../node_modules/font-awesome/css/font-awesome.css"
export default {
  name: 'done',
  data() {
    return {
    }
  },
  methods: {
    show: function () {
      $('.hero-body').css('opacity','1');
    },
    go: function() {
      router.push('/');
    }
  },
  created: function () {
      setTimeout(this.go, 10000);
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .hero-body {
      opacity: 1;
      -webkit-transition: all 1s ease-in-out;
      -moz-transition: all 1s ease-in-out;
      -o-transition: all 1s ease-in-out;
      transition: all 1s ease-in-out;

    }
    * {
      color: white;
    }
    span.green, span.green>i {
      color: #23d160;
    }
    span.red>i {
      color: #ff3860;
    }
</style>