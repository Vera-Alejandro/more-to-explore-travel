<template>
  <v-app>
    <div v-if="releaseStatus === 'SiteReady'">
      <Navigation />
      <v-main>
        <router-view :key="$route.fullPath" />
      </v-main>
      <v-footer>
        <v-col class="text-center">
          {{ new Date().getFullYear() }} - <strong>Alejandro</strong>
          <div class="icon-shoutout">
            Icons made by
            <a
              href="https://www.flaticon.com/authors/good-ware"
              title="Good Ware"
              >Good Ware</a
            >
            from
            <a href="https://www.flaticon.com/" title="Flaticon"
              >www.flaticon.com</a
            >
          </div>
        </v-col>
      </v-footer>
    </div>
    <div v-if="releaseStatus === 'ComingSoon'">
      <CommingSoon />
    </div>
  </v-app>
</template>

<script>
import Navigation from "./components/Navigation";
import CommingSoon from "./ComingSoon";

export default {
  name: "App",

  components: {
    Navigation,
    CommingSoon,
  },

  data: () => ({
    releaseStatus: process.env.VUE_APP_RELEASE_READY,
  }),
};
</script>

<style scoped>
.icon-shoutout {
  font-size: 10px;
}
</style>
