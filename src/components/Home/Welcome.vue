<template>
  <div>
    <v-container class="welcome-container">
      <v-row class="main-row">


        <v-col class="text-cont" :cols="textColumnWidth">
          <v-row>

          <h2>Welcome!</h2>
          <div class="welcome-msg">
            <p>
              Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien
              lacus in massa. Vivamus sodales, lacus mattis tincidunt efficitur,
              erat nibh accumsan ex, et ornare ex ligula ut turpis. Sed interdum
              placerat lacus, nec fermentum augue auctor et.
            </p>
          </div>
          </v-row>
          <v-row>
          <v-btn class="aboutMeBtn" @click="redirectAboutMe" color="#BBE1FA"
            >Get To Know Me!</v-btn>
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

  <!-- <v-container class="cont">
    <v-row class="row1">
      <v-col class="text-col">
        <v-row class="msg-row"></v-row>
        <v-row class="btn-row"></v-row>
        </v-col>
      <v-col class="pic-col"></v-col>
    </v-row>
  </v-container> -->
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
    textColumnWidth() { return window.innerWidth > 600 ? 8 : 0; },
    imageColumnWidth() { return window.innerWidth > 600 ? 4 : 0; },
    }
};
</script>

<style scoped>
.welcome-container {
  padding: 2rem;
  clear: both;
  max-width: 1300px;
  background-image: linear-gradient(#3282b8, #bbe1fa);
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

img {
  width: 100%;
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

  img {
    width: 100%;
    height: 100%;
  }
}

aside {
  max-height: 100%;
}
</style>