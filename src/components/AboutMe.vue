<template>
  <div>
    <header>
      <h1>About Me</h1>
    </header>
    <main>
      <Introduction/>

      <v-divider></v-divider>
      <LoveForTravel/>

    </main>
  </div>
</template>

<script>
import Introduction from './About Me/Introduction';
import LoveForTravel from './About Me/LoveForTravel';

export default {
  name: "AboutMe",
  components: {
    Introduction,
    LoveForTravel,
    },
    data: () => ({
      name: 'f',
    }),
  methods: {},
};
</script>

<style>


</style>