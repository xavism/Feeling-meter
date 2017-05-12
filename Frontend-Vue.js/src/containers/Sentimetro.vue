<template>
  <div class="sentimetro">
    <div class="columns">
        <div class="column" id="work-column">
            <options v-on:choose="makeTrue(0)" :data="optionsData[0]" v-model="inputs[0]"></options>
        </div>
        <div class="column" id="feeling-column">
            <options v-on:choose="makeTrue(1)" :data="optionsData[1]" v-model="inputs[1]"></options>
        </div>
    </div>
    <footerButton v-model="inputs" :title="titleButton"></footerButton>
  </div>
</template>

<script>
import options from './../components/Options'
import footerButton from './../components/Footer'
import toastr from 'toastr'
import JobService from './../services/JobService.js'
import $ from 'jquery'

$(window).on('load', function() {
		// Animate loader off screen
		$(".se-pre-con").fadeOut("slow");
	});

const optionsData = [
    {title: "How much <span class='light'>work</span> did you have?", icons: ["Low","Mid","High"]},
    {title: "How did you <span class='light'>feel</span> while working?", icons: ["Happy","Normal","Stressed"]}
]
const titleButton = "Send Me!"
export default {
  name: 'sentimetro',
  components: {
      options,
      footerButton
  },
  data() {
    return {
        optionsData: optionsData,
        titleButton: titleButton,
        inputs: [{selection: "", status: false },{selection: "", status: false}]
    }
  },
  methods: {
    makeTrue: function(index) {
      this.inputs[index].status = true;
    },
    makeSelection: function(data) {
      console.log(data);
    }
  }
}
console.log(this);

// this.$on('select', function (data) {
//   console.log(data)
// })
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .column {
      -webkit-transition: all 1s ease-in-out;
      -moz-transition: all 1s ease-in-out;
      -o-transition: all 1s ease-in-out;
      transition: all 1s ease-in-out;

    }


    .column {
        padding: 0;
    }
    .brand {
      position: fixed;
      margin-left: auto;
      margin-right: auto;
      left: 0;
      right: 0;
    }
</style>