<template>
  <div>
    <div class="header-container">
      <v-carousel>
        <v-carousel-item
        class="carousel-img"
        v-for="(ss_img, i) in slideshow_images"
        :key="i"
        :src="ss_img.src"
        reverse-transition="fade-transition"
        transition="fade-transition"
        ></v-carousel-item>
      </v-carousel>
    </div>

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
          //Vacations
          active: false,
          url: "/services",
        },
        {
          text: "About Me",
          active: true,
          url: "/aboutme",
        },
        {
          text: "Blog",
          active: false,
          url: "/blog",
        },
        {
          text: "Contact",
          active: false,
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