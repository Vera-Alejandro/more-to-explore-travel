<template>
  <v-app>
    <Navigation />
    <v-main>
      <router-view :key="$route.fullPath" />
    </v-main>
    <v-footer>
      <v-col class="text-center">
        {{ new Date().getFullYear() }} - <strong>Alejandro</strong>
        <div class="icon-shoutout">
          Icons made by
          <a href="https://www.flaticon.com/authors/good-ware" title="Good Ware"
            >Good Ware</a
          >
          from
          <a href="https://www.flaticon.com/" title="Flaticon"
            >www.flaticon.com</a
          >
        </div>
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

<style scoped>
.icon-shoutout {
  font-size: 10px;
}
</style>
