<template>
  <v-app>
    <Navigation />
    <v-main>
      <router-view :key="$route.fullPath" />
    </v-main>
    <v-footer>
      <v-col class="text-center">
        {{ new Date().getFullYear() }} - <strong>Alejandro</strong>
      </v-col>
    </v-footer>
  </v-app>
</template>

<script>
import Navigation from "./components/Navigation";

export default {
  name: "App",

  components: {
    Navigation,
  },

  data: () => ({
    //
  }),
};
</script>
