<template>
  <div class="main-container">
    <div class="intro-container">
      <div class="text-cont">
        <h2 class="local-title">{{ articleTitle }}</h2>
        <article class="reasons-for-travel">
          <p>{{ articleText }}</p>
        </article>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "LoveForTravel",
  data: () => ({
    articleTitle: "I love to travel because...",
    articleText:
      "Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien lacus in massa. Vivamus sodales, lacus mattis tincidunt efficitur, erat nibh accumsan ex, et ornare ex ligula ut turpis. Sed interdum placerat lacus, nec fermentum augue auctor et.",
    d: "",
  }),
};
</script>

<style scoped>
.main-container {
  background-image: linear-gradient(#0f4c75, #bbe1fa);
}

.intro-container {
  height: 10rem;
  margin: 2rem;
  padding-top: 1rem;
  clear: both;
  max-width: 1300px;
}

.text-cont {
  width: 100%;
  height: 100%;
  float: left;
}

.local-title {
  font-family: "Satisfy", cursive;
  font-size: 2rem;
  color: white;
}

.reasons-for-travel {
  float: left;
  color: white;
}

.profile-picture {
  height: 25rem;
  max-width: 100%;
}

.profile-picture img {
  max-height: 100%;
}

</style>