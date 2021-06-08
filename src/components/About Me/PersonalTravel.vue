<template>
  <div class="main-container">
    <v-container>
      <v-row class="travel-exp">
        <v-col class="text-col" :cols="textColumnWidth">
          <h2 class="local-title">{{ experienceTitle }}</h2>
          <div class="travel-experience">
            <p>{{ experienceText }}</p>
          </div>
        </v-col>
        <v-col class="img-col" :cols="imageColumnWidth">
          <v-row class="top-img pic">
            <img
              class="personal-vacation"
              src="https://moretoexploreapistorage.blob.core.windows.net/site-images/beach.jpg"
              alt=""
            />
          </v-row>
          <v-row class="bott-img pic"> </v-row>
        </v-col>
      </v-row>
      <v-row class="bucket-list">
        <v-col class="text-col" :cols="textColumnWidth">
          <h2 class="local-title">{{ bucketlistTitle }}</h2>
          <div class="travel-destinations">
            <p>{{ bucketlistText }}</p>
          </div>
        </v-col>
        <v-col class="img-col" :cols="imageColumnWidth">
          <v-row class="top-img pic">
            <img
              class="personal-vacation"
              src="https://moretoexploreapistorage.blob.core.windows.net/site-images/beach.jpg"
              alt=""
            />
          </v-row>
          <v-row class="bott-img pic">
            <img
              class="personal-vacation"
              src="https://moretoexploreapistorage.blob.core.windows.net/site-images/beach.jpg"
              alt=""
            />
          </v-row>
        </v-col>
      </v-row>
    </v-container>
  </div>
</template>

<script>
export default {
  name: "PersonalTravel",

  data: () => ({
    experienceTitle: "Where I've been...",
    experienceText:
      "Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien lacus in massa. Vivamus sodales, lacus mattis tincidunt efficitur, erat nibh accumsan ex, et ornare ex ligula ut turpis. Sed interdum placerat lacus, nec fermentum augue auctor et.",
    bucketlistTitle: "Where I want to go...",
    bucketlistText:
      "Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien lacus in massa. Vivamus sodales, lacus mattis tincidunt efficitur, erat nibh accumsan ex, et ornare ex ligula ut turpis. Sed interdum placerat lacus, nec fermentum augue auctor et.",
  }),
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
.main-container {
  display: flex;
  padding: 1rem;
}

.local-title {
  font-family: "Satisfy", cursive;
  font-size: 2rem;
}

@media screen and (max-width: 600px) {
  .travel-exp, .bucket-list {
    flex-direction: column;
  }
}

p {
  font-family: "Libre Baskerville", serif;
}

img {
  height: 100%;
  width: 100%;
  padding: 0.5rem;
}
</style>