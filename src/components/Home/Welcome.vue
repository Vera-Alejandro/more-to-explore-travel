<template>
  <div class="container grid grid-rows-3 gap-4 grid-flow-col">
    <div class="row-span-3">
      <img
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/ellie-seaside.png"
        alt=""
      />
    </div>
    <div class="col-span-2 row-span-2">
      <p>
        {{ welcomeParagraph }}
      </p>
    </div>
    <div class="col-span-2">
      <v-btn class="aboutMeBtn" @click="redirectAboutMe" color="#BBE1FA"
        >Get To Know Me!</v-btn>
    </div>
  </div>
</template>

<script>
export default {
  name: "Welcome",
  data() {
    return {
      welcomeParagraph:
        "Hi everyone! I’m Ellie Boyer, owner of More to Explore Travel. As a travel advisor, it’s my goal to make traveling simpler and more achievable for couples, groups, and families. It’s also my goal for all of my clients to have unforgettable experiences and create wonderful memories while traveling the world together. If you’re looking to travel more and stress less, you’ve come to the right place. Remember, there’s always more to explore!",
      inDevAlert: false,
    };
  },
  methods: {
    redirectAboutMe() {
      document.body.scrollTop = 0;
      document.documentElement.scrollTop = 0;
      this.$router.push("/aboutme");
    },
  },
};
</script>

<style scoped>
</style>