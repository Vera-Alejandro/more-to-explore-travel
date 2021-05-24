<template>
  <v-app>
    <Navigation/>
    <v-main>
    </v-main>
  </v-app>
</template>

<script>
import Navigation from './components/Navigation';


export default {
  name: 'App',

  components: {
    Navigation,
    // HomePage,
    // Services,
    // AboutMe,
    // Blog,
    // Contact
  },

  data: () => ({
    //
  }),
};
</script>
