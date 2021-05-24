<template>
  <v-toolbar dark flat>
    <v-toolbar-title>More To Explore Travel</v-toolbar-title>
    <v-spacer></v-spacer>
    <v-toolbar-items v-for="item in nav" :key="item.icon" :title="item.title" >
      <v-btn>{{ item.text }}</v-btn>
    </v-toolbar-items>
  </v-toolbar>
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
          title: "Back to Home page",
          active: true,
        },
        {
          text: "Services",
          title: "About this demo",
          active: true,
        },
        {
          text: "About Me",
          title: "Some stuff that needs doing",
          active: true,
        },
        {
          text: "Blog",
          title: "Our Contact info",
          active: false,
        },
        {
          text: "Contact",
          title: "Our Contact info",
          active: true,
        },
      ],
    };
  },
};
</script>

<style>
</style>