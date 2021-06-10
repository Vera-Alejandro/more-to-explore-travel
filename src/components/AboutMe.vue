<template>
  <div>
    <header>
      <h1>About Me</h1>
    </header>
    <main>
      <Introduction/>

      <v-divider></v-divider>
      <LoveForTravel/>

      <v-divider></v-divider>
      <PersonalTravel/>
    </main>
  </div>
</template>

<script>
import Introduction from './About Me/Introduction';
import LoveForTravel from './About Me/LoveForTravel';
import PersonalTravel from './About Me/PersonalTravel';

export default {
  name: "AboutMe",
  components: {
    Introduction,
    LoveForTravel,
    PersonalTravel,

    },
    data: () => ({
    }),
  methods: {},
};
</script>

<style>


</style>