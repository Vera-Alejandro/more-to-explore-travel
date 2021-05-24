<template>
  <v-app>
    <Navigation/>
    <home-page/>
    <v-main>
    </v-main>
  </v-app>
</template>

<script>
import Navigation from './components/Navigation';
import HomePage from './components/HomePage';

export default {
  name: 'App',

  components: {
    Navigation,
    HomePage
  },

  data: () => ({
    //
  }),
};
</script>
