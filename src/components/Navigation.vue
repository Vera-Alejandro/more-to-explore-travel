<template>
<div>
  <v-toolbar dark flat src="../assets/map-travel.jpg" height="350">
    <v-toolbar-title color="black">More To Explore Travel</v-toolbar-title>
    <v-spacer></v-spacer>
    <v-toolbar-items @click="GoToPage(item.url)" v-for="item in nav" :key="item.icon" :title="item.title" height="10">
      <v-btn text color="black">{{ item.text }}</v-btn>
    </v-toolbar-items>
  </v-toolbar>
</div>
</template>

<script>
export default {
  name: "Navigation",
  data() {
    return {
      dialog: false,
      nav: [
        {
          text: "Home",
          title: "--to do--",
          active: true,
          url: "/"
        },
        {
          text: "Services",
          title: "--to do--",
          active: true,
          url: "/"
        },
        {
          text: "About Me",
          title: "--to do--",
          active: true,
          url: "/"
        },
        {
          text: "Blog",
          title: "--to do--",
          active: false,
          url: "/"
        },
        {
          text: "Contact",
          title: "--to do--",
          active: true,
          url: "/"
        },
      ],
    };
  },
  methods: {
    goToPage(page) {
      this.$router.push(page);
    }
    }
};
</script>

<style>
</style>