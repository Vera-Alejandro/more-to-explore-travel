<template>
  <div class="home-header">
    <v-row class="header-row">
      <v-col class="split-col">
        <v-row class="logo-row">
          <div class="logo-cont" align-center>
            <h1 id="logo-title">More To Explore</h1>
          </div>
        </v-row>
        <v-row class="header-img lower-row">
          <v-img id="img-1" src="https://moretoexploreapistorage.blob.core.windows.net/site-images/OceanandCliffs.jpg"></v-img>
        </v-row>
      </v-col>
      <v-col  class="header-img">
        <v-img id="img-2" src="https://moretoexploreapistorage.blob.core.windows.net/site-images/BeachView.jpg"></v-img>
      </v-col>
      <v-col  class="header-img">
        <v-img id="img-3" src="https://moretoexploreapistorage.blob.core.windows.net/site-images/PalmTreeLightHouse.jpg"></v-img>
      </v-col>
    </v-row>
  </div>
</template>

<script>
export default {

}
</script>

<style scoped>
.home-header {
background-color: black;

}

.header-row {
  height: 100%;
}

.logo-row {
  height: 30%;
}

.logo-cont { 
  height: 100%;
  width: 100%;
  position: relative;
}

.lower-row {
  height: 60%;
}

.header-img {
  max-width: 30vw;

}

#img-1 {
  margin-left: 2rem;
}

#img-2 {
    margin-top: 10vh;
}

#img-3 {
}

#logo-title {
  color: #4E5255;
  text-align: center;
  position: absolute;
  width: 15rem;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  font-size: 3rem;
}
</style>