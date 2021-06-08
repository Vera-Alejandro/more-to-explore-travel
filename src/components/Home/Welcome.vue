<template>
  <div class="welcome-container">
    <v-container>
      <v-row class="main-row">
        <v-col class="text-cont" :cols="textColumnWidth">
          <v-row>
            <h2>Welcome!</h2>
            <div class="welcome-msg">
              <p>
                I'm Ellie, and welcome to More to Explore Travel! 
                I have always loved to travel with my family and freidns, try new foods, 
                and experience different cultures. Now, it is my goal to help others do the same. 
                If you are looking to go on a stress-free, unforgettable getaway with your loved ones, 
                you came to the right place!
              </p>
            </div>
          </v-row>
          <v-row>
            <v-btn class="aboutMeBtn" @click="redirectAboutMe" color="#BBE1FA"
              >Get To Know Me!</v-btn
            >
          </v-row>
        </v-col>

        <v-col class="img-cont" :cols="imageColumnWidth">
          <img
            src="https://moretoexploreapistorage.blob.core.windows.net/site-images/profile-pic.jpg"
            alt=""
          />
        </v-col>
      </v-row>
    </v-container>
  </div>
</template>

<script>
export default {
  name: "Welcome",
  data() {
    return {
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
  computed: {
    textColumnWidth() {
      console.log(window.outerWidth);
      return window.outerWidth > 600 ? 8 : 0;
    },
    imageColumnWidth() {
      return window.outerWidth > 600 ? 4 : 0;
    },
  },
};
</script>

<style scoped>
.welcome-container {
  padding: 2rem;
  clear: both;
  background-image: linear-gradient(#3282b8, #bbe1fa);
}

.main-row {
  max-width: 1100px;
}

.text-cont h2 {
  font-family: "Satisfy", cursor;
  color: whitesmoke;
  font-size: 3rem;
  font-weight: 500;
}

.text-cont {
  padding: 2rem;
}

.img-cont {
  height: 100%;
  width: 100%;
  padding-right: 2rem;
}

.welcome-msg {
  float: left;
  font-weight: 300;
  padding-left: 1rem;
  font-family: "Libre Baskerville", serif;
  color: white;
}

.aboutMeBtn {
  padding-left: 0.25rem;
  margin: 1rem;
  color: #1b262c;
  font-family: "Libre Baskerville", serif;
}

@media screen and (max-width: 600px) {
  .welcome-container {
    height: 55rem;
    flex-wrap: wrap;
    text-align: center;
    width: 100%;
  }

  .main-row {
    flex-direction: column;
  }

  .text-cont,
  .img-cont {
    width: 100%;
    height: 45%;
  }

  .img-cont {
    padding: 0;
    padding-top: 2.5rem;
  }

  .aboutMeBtn {
    align-content: center;
    margin: 0 auto;
    display: block;
  }

  .welcome-msg {
    padding-bottom: 2rem;
  }
  .welcome-img {
    width: 100%;
    height: 100%;
  }
}

aside {
  max-height: 100%;
}

img {
  width: 100%;
  height: 100%;
}
</style>