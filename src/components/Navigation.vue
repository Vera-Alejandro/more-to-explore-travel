<template>
  <div>
    <img src="../assets/vacation.jpg" alt="site title page. More To Explore Travel">
    <v-toolbar class="nav-bar" flat>
      <v-toolbar-items
        class="nav-btn"
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
.nav-bar {
  padding-left: 10%;
}

.nav-btn {
  padding-left: 7%;
}
</style>