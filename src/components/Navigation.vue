<template>
  <div>
    <v-toolbar dark flat src="../assets/map-travel.jpg" height="350">
      <v-toolbar-title color="black">More To Explore Travel</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-toolbar-items
        @click="goToPage(item.url)"
        v-for="item in displayNav"
        :key="item.url"
        :title="item.title"
        height="10"
      >
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
      fullNav: [
        {
          text: "Home",
          title: "--to do--",
          active: true,
          url: "/",
        },
        {
          text: "Services",
          title: "--to do--",
          active: true,
          url: "/services",
        },
        {
          text: "About Me",
          title: "--to do--",
          active: true,
          url: "/aboutme",
        },
        {
          text: "Blog",
          title: "--to do--",
          active: false,
          url: "/blog",
        },
        {
          text: "Contact",
          title: "--to do--",
          active: true,
          url: "/contact",
        },
      ],
    };
  },
  methods: {
    goToPage(page) {
      let from = localStorage.getItem('LS_ROUTE_PATH');
      if(from != page) {
        this.$router.push(page);
      }
    },
  },
  computed: {
    displayNav() {
      return this.fullNav.filter(paths => paths.active);
    }
  }
};
</script>

<style>
</style>