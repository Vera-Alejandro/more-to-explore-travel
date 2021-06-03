<template>
  <div class="welcome-container">
    <div class="text-cont">
      <h2>Welcome!</h2>
      <article class="welcome-msg">
        <p>
          Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien lacus in
          massa. Vivamus sodales, lacus mattis tincidunt efficitur, erat nibh
          accumsan ex, et ornare ex ligula ut turpis. Sed interdum placerat
          lacus, nec fermentum augue auctor et.
        </p>
      </article>
      <v-btn class="aboutMeBtn" @click="redirectAboutMe" color="#BBE1FA">Get To Know Me!</v-btn>
    </div>
    <div class="img-cont">
      <aside class="welcome-img">
        <img src="https://moretoexploreapistorage.blob.core.windows.net/site-images/profile-pic.jpg" alt="" />
      </aside>
    </div>

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
      this.$router.push('/aboutme');
    }
  }
};
</script>

<style scoped>
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

.text-cont h2{
  font-family:"Satisfy", cursor;
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

.welcome-img img {
  max-height: 100%;
  box-shadow: 10px;
}

.aboutMeBtn {
  padding-left: .25rem;
  margin: 1rem;
  color: #1B262C;
  font-family: "Libre Baskerville", serif;
}

p {

}

aside {
  max-height: 100%;
}
</style>