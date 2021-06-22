<template>
  <v-app>
    <div v-if="releaseStatus === 'SiteReady' || backdoorEnabled">
      <Navigation />
      <v-main>
        <router-view :key="$route.fullPath" />
      </v-main>
      <v-footer>
        <v-col class="text-center">
          <a href="https://veraalejandro.com">
          {{ new Date().getFullYear() }} - <strong>Built by Alejandro</strong>
          </a>
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
    <div v-if="releaseStatus === 'ComingSoon' && backdoorEnabled === false">
      <CommingSoon @EnableBackdoor="RevealSite" />
    </div>
  </v-app>
</template>

<script>
import Navigation from "./components/Navigation";
import CommingSoon from "./ComingSoon";
import { ApplicationInsights } from "@microsoft/applicationinsights-web";

const appInsights = new ApplicationInsights({
  config: {
    instrumentationKey: process.env.VUE_APP_INSTRUMENTAION_KEY
  },
});
appInsights.loadAppInsights();
appInsights.trackPageView();

export default {
  name: "App",

  components: {
    Navigation,
    CommingSoon,
  },

  data: () => ({
    releaseStatus: process.env.VUE_APP_RELEASE_READY,
    backdoorEnabled: false,
  }),
  methods: {
    RevealSite(value) {
      console.log(value);
      this.backdoorEnabled = true;
      document.body.scrollTop = 0;
      document.documentElement.scrollTop = 0;
      // this.$router.push("/aboutme");
    },
  },
};
</script>

<style scoped>
.icon-shoutout {
  font-size: 10px;
}
</style>
