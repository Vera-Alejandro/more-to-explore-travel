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
      <li><a>{{ item.text }}</a></li>
        <!-- <v-btn text color="black">{{ item.text }}</v-btn> -->
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
  margin: 0;
  padding: 0;
  list-style: none;
  display: inline-block;
  margin-left: 6rem;
  padding-top: .5rem;
}

.nav-btn li a {
  color: blue;
  text-decoration: none;
  text-transform: uppercase;
  position: relative;
}

.nav-btn li a:hover {
  color: black;  
}

.nav-btn li a:before {
  content: '';
  display: block;
  height: 5px;
  background: #444;  

  top: 0;
  width: 0%;

  transition: all ease-in-out 250ms;
}

.nav-btn li a:hover::before {
width: 100%;
}

</style>