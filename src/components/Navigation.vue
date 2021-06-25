<template>
  <div class="home-header">
    <v-row class="header-row">
      <v-col class="split-col">
        <v-row class="logo-row"></v-row>
        <v-row id="img-1" class="header-img"></v-row>
      </v-col>
      <v-col id="img-2" class="header-img"></v-col>
      <v-col id="img-3" class="header-img"></v-col>
    </v-row>

    <div id="nav-btn" class="overlay">
      <a href="javascript:void(0)" class="close-btn" @click="closeNav"
        >&times;</a
      >
      <div class="overlay-content">
        <ul>
          <li
            v-for="item in displayNav"
            :key="item.url"
            @click="goToPage(item.url)"
            class="nav-btn"
          >
            <a>{{ item.text }}</a>
          </li>
        </ul>
      </div>
    </div>

    <span class="menu-btn" @click="openNav">&#9776;</span>
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
          active: true,
          url: "/",
        },
        {
          text: "Services",
          active: true,
          url: "/services",
        },
        {
          text: "About Me",
          active: true,
          url: "/aboutme",
        },
        {
          text: "Blog",
          active: true,
          url: "/blog",
        },
        {
          text: "Contact",
          active: true,
          url: "/contact",
        },
      ],
      slideshow_images: [
        {
          src: "https://moretoexploreapistorage.blob.core.windows.net/site-images/nav-img1.png" 
        },
        {
          src: "https://moretoexploreapistorage.blob.core.windows.net/site-images/nav-img2.jpg" 
        },
        {
          src: "https://moretoexploreapistorage.blob.core.windows.net/site-images/nav-img3.jpg" 
        },
      ]
    };
  },
  methods: {
    goToPage(page) {
      let from = localStorage.getItem("LS_ROUTE_PATH");
      
      if (from != page) {
        this.$router.push(page);
        console.log(this.$route.query.page);
        this.closeNav();
      }
    },
    closeNav() {
      document.getElementById("nav-btn").style.width = "0%";
    },
    openNav() {
      document.getElementById("nav-btn").style.width = "100%";
      document.getElementById("app").style.overflow = "hidden";
    },
  },
  computed: {
    displayNav() {
      return this.fullNav.filter((paths) => paths.active);
    },
  },
};
</script>

<style scoped lang="scss">
/* nav menue styling */
.home-header {
  background-color:black;
  height: 60vh;
}

.header-row {
  height: 100%;
  background-color: lightgray;
}

.split-col {
  background-color: #3498db;
}

.logo-row {
  background-color: lightblue;
  height: 40%;
}


#img-1 {
  background-color: lightcoral;
  height: 60%;
  width: auto;
}

#img-2 {
  background-color: lightgreen;
  
}

#img-3 {
  background-color: lightpink;
}



.overlay {
  height: 100%;
  width: 0;
  position: fixed;
  z-index: 1;
  left: 0;
  top: 0;
  background-color: rgba(0, 0, 0, 0.9);
  overflow: hidden;
  transition: 0.5s;
}

.overlay-content {
  position: relative;
  top: 25%;
  width: 100%;
  text-align: center;
  margin-top: 30px;
}

.overlay a {
  padding: 8px;
  text-decoration: none;
  font-size: 36px;
  color: #818181;
  display: block;
  transition: 0.3s;
}

.overlay a:hover,
.overlay a:focus {
  color: #f1f1f1;
}

.overlay .close-btn {
  position: absolute;
  top: 0%;
  right: 5%;
  font-size: 60px;
}

.menu-btn {
  position: absolute;
  top: 1%;
  right: 5%;
  font-size: 45px;
  color: white;
}

.carousel-img{
  width: 100%;
  // height: 85%;
}

@media screen and (max-height: 450) {
  .overlay a {
    font-size: 20px;
  }
  .overlay .close-btn {
    font-size: 40px;
    top: 15px;
    right: 35px;
  }
}

ul {
  display: flex;
  flex-direction: column;
  align-items: center;
  list-style-type: none;

  li {
    padding: 6px 0;

    a {
      position: relative;
      display: block;
      padding: 4px 0;
      font-family: 'Libre Baskerville', serif;
      color: #ecf0f1;
      text-decoration: none;
      text-transform: uppercase;
      transition: 0.5s;

      &::after {
        position: absolute;
        content: "";
        top: 100%;
        left: 0;
        width: 100%;
        height: 3px;
        background: #3498db;
        transform: scaleX(0);
        transform-origin: right;
        transition: transform 0.5s;
      }

      &:hover {
        color: #95a5a6;
      }

      &:hover::after {
        transform: scaleX(1);
        transform-origin: left;
      }
    }
  }
}

.header-img {
  width: 100%;
}
</style>