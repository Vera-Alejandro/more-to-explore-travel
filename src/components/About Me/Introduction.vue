<template>
  <div class="intro-container">
    <div class="text-cont">
      <h2 class="local-title">{{ articleTitle }}</h2>
      <article class="welcome-msg">
        <p>{{ articleText }}</p>
      </article>
    </div>

    <div class="img-cont">
      <aside class="profile-picture">
        <img src="https://moretoexploreapistorage.blob.core.windows.net/site-images/profile-pic.jpg" alt="" />
      </aside>
    </div>
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
};
</script>

<style scoped>
.local-title {
  font-family: "Satisfy", cursive;
  font-size: 2rem;
}

.intro-container {
  height: 15rem;
  margin: 2rem;
  clear: both;
  max-width: 1300px;
}

.text-cont {
  width: 60%;
  height: 100%;
  float: left;
}

.img-cont {
  width: 40%;
  height: 100%;
  float: right;
  text-align: center;
}

.welcome-msg {
  float: left;
}

.profile-picture {
  height: 25rem;
  max-width: 100%;
}

.profile-picture img {
  max-height: 100%;
}

aside {
  max-height: 100%;
}
</style>