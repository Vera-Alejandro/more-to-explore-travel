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
          icon: "home",
          text: "Home",
          title: "Back to Home page",
          active: true,
        },
        {
          icon: "info",
          text: "About",
          title: "About this demo",
          active: false,
        },
        {
          icon: "assignment_turned_in",
          text: "Todos",
          title: "Some stuff that needs doing",
          active: false,
        },
        {
          icon: "email",
          text: "Contact",
          title: "Our Contact info",
          active: false,
        },
      ],
    };
  },
};
</script>

<style>
</style>