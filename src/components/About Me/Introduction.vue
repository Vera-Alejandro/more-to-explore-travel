<template>
  <div class="intro-container">
    <v-container>
      <v-row class="main-row">
        <v-col class="text-cont" :cols="textColumnWidth">
          <h2 class="local-title">{{ articleTitle }}</h2>
          <div class="welcome-msg">
            <p>{{ articleText }}</p>
          </div>
        </v-col>
        <v-col class="img-cont" :cols="imageColumnWidth">
          <img 
            class="profile-pic"
            src="https://moretoexploreapistorage.blob.core.windows.net/site-images/about-me-img.jpg"
            alt=""
          />
        </v-col>
      </v-row>
    </v-container>
  </div>
</template>

<script>
export default {
  name: "Introduction",
  data: () => ({
    articleText:
      "Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien lacus in massa. Vivamus sodales, lacus mattis tincidunt efficitur, erat nibh accumsan ex, et ornare ex ligula ut turpis. Sed interdum placerat lacus, nec fermentum augue auctor et.",
    articleTitle: "Hello Travelers!",
  }),
  computed: {
    textColumnWidth() {
      return window.outerWidth > 600 ? 8 : 0;
    },
    imageColumnWidth() {
      return window.outerWidth > 600 ? 4 : 0;
    }
  },
};
</script>

<style scoped>
.local-title {
  font-family: "Satisfy", cursive;
  font-size: 2rem;
}

.intro-container {
  clear: both;
  max-width: 1300px;
}

.main-row {
  height: 100%;
}

.img-container, .text-cont {
  height: 100%;
}

.welcome-msg {
  font-family: "Libre Baskerville", serif;
  font-size: 1.25rem;
  padding: 2rem;
  padding-top: 2.5rem;
  text-align: center;
}

.profile-pic {
    border-radius: 50px;
}

@media screen and (max-width: 600px) {
  .intro-container {
    flex-wrap: wrap;
    text-align: center;
  }

  .main-row {
    flex-direction: column;
  }
  
  .text-cont, .img-cont {
    width: 100%;
    /* height: 45%; */
  }

  .img-cont {
    padding: 0;
  }

  .profile-pic {
    height: 100%;
    width: 100%;
    padding: 1rem;
  }

}

img {
  height: 100%;
  width: 100%;
}

</style>