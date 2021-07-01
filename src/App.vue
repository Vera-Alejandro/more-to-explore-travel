<template>
  <v-app class="w-screen">
        <div class="site-container">
    <div v-if="releaseStatus === 'SiteReady' || backdoorEnabled">
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
    <div v-if="releaseStatus === 'ComingSoon' && backdoorEnabled === false">
      <CommingSoon @EnableBackdoor="RevealSite" />
    </div>
        </div>
  </v-app>
</template>

<script>
import Navigation from "./components/Navigation";
import CommingSoon from "./ComingSoon";
import { ApplicationInsights } from "@microsoft/applicationinsights-web";

const appInsights = new ApplicationInsights({
  config: {
    instrumentationKey: "4fc69f0e-a627-440f-8adb-85dad0c8d7ea",
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
    RevealSite() {
      this.backdoorEnabled = true;
      document.body.scrollTop = 0;
      document.documentElement.scrollTop = 0;
    },
  },
};
</script>

<style scoped lang='scss'>
.icon-shoutout {
  font-size: 10px;
}

.container {
  margin : 0;
  padding: 0;
}

</style>
