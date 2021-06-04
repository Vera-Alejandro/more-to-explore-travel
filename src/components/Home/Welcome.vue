<template>
  <div>
    <v-container class="welcome-container">
      <v-row>


        <v-col class="text-cont">
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

        <v-col class="img-cont">
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
};
</script>

<style scoped>
.cont {
  height: 320px;
  width: 981px;
  background-color: #3282b8;
}

.row1 {
  height: 256px;
  background-color: brown;
}

.text-col {
  width: 60%;
  background-color: yellow;
}

.pic-col {
  /* width: 367px; */
  background-color: greenyellow;
}

.msg-row {
  background-color: aqua;
  height: 80%;
}

.btn-row {
  background-color: purple;
  height: 30%;
}

.welcome-container {
  height: 20rem;
  padding: 2rem;
  clear: both;
  max-width: 1300px;
  background-image: linear-gradient(#3282b8, #bbe1fa);
}

.text-cont {
  width: 60%;
  height: 100%;
  float: left;
}

.text-cont h2 {
  font-family: "Satisfy", cursor;
  color: whitesmoke;
  font-size: 3rem;
  font-weight: 500;
}

.img-cont {
  width: 40%;
  height: 100%;
  float: right;
  text-align: center;
}

.welcome-msg {
  float: left;
  font-weight: 300;
  padding-left: 1rem;
  font-family: "Libre Baskerville", serif;
  color: white;
}

.welcome-img {
  height: 25rem;
  max-width: 100%;
}

img {
  height: 100%;
  box-shadow: 10px;
}

.aboutMeBtn {
  padding-left: 0.25rem;
  margin: 1rem;
  color: #1b262c;
  font-family: "Libre Baskerville", serif;
}

@media screen and (max-width: 600px) {
  .welcome-container {
    height: 50rem;
  }

  .text-cont,
  .img-cont {
    width: 100%;
    height: 45%;
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