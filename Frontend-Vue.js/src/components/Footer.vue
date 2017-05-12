<template>
  <div class="footer-button">
    <a id="send-button" @click="send" class="button is-primary is-outlined">{{ title }}</a>
  </div>
</template>

<script>
import toastr from 'toastr'
import router from './../router'
import './../../node_modules/toastr/build/toastr.css';
import $ from 'jquery'
import JobService from './../services/JobService.js'

export default {
  name: 'footerButton',
  props: ['title', 'value'],
  data() {
    return {}
  },
  methods: {
    send: function () {
      if (this.value[0].status == false || this.value[1].status == false) toastr.error("Both fields have to be informed");
      else {
        let self = this;
        let data = {work: this.value[0].selection, feeling: this.value[1].selection};
        JobService.create(data)
            .then(function (response) {
                  $('#work-column').css("margin-left","-1600px");
                  $('#feeling-column').css("margin-right","-1600px");
                  $('#send-button').css("opacity","0");
                  setTimeout(self.go, 1100);
            })
            .catch(function (error) {
                console.log(error);
                toastr.error("Something went wrong while submitting your information");
            });
      }
    },
    go: function() {
      router.push('done');
      this.$emit('loadResponse');
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  #send-button {
      -webkit-transition: all 1s ease-in-out;
      -moz-transition: all 1s ease-in-out;
      -o-transition: all 1s ease-in-out;
      transition: all 1s ease-in-out;

    }

 .footer-button {
   text-align: center;
   bottom: 0;
   position: absolute;
    margin-left: auto;
    margin-right: auto;
    left: 0;
    right: 0;
 }

 a {
     font-size: 40px;
 }

</style>