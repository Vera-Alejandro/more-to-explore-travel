<template>
  <v-app>
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
          <div>
            <a
              href="https://app.termly.io/notify/22e25919-73a5-4ac2-bd22-6d6e360f992a"
            >
              Do not sell my info
            </a>
            <a href="/privacypolicy"> Privacy Policy</a>
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
    RevealSite(value) {
      console.log(value);
      this.backdoorEnabled = true;
      document.body.scrollTop = 0;
      document.documentElement.scrollTop = 0;
    },
    goToPrivacyPolicy() {
      let from = localStorage.getItem("LS_ROUTE_PATH");
      const ppPath = "/privacypolicy";

      if (from != ppPath) {
        this.$router.push(ppPath);
        console.log(this.$route.query.page);

        document.body.scrollTop = 0;
        document.documentElement.scrollTop = 0;
      }
    },
  },
};
</script>

<style scoped>
.icon-shoutout {
  font-size: 10px;
}
</style>
