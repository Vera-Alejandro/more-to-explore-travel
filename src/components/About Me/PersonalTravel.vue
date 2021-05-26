<template>
  <div class="main-container">
    <div class="exp-container">
      <div class="travel-container">
        <div class="text-cont">
          <h2 class="local-title">{{ experienceTitle }}</h2>
          <article class="travel-experience">
            <p>{{ experienceText }}</p>
          </article>
        </div>
      </div>

      <div class="travel-container">
        <div class="text-cont">
          <h2 class="local-title">{{ bucketlistTitle }}</h2>
          <article class="travel-destinations">
            <p>{{ bucketlistText }}</p>
          </article>
        </div>
      </div>
    </div>

    <div class="img-container">
      <aside class="img-aside">
        <div class="odd-img">
          <img
            class="personal-vacation"
            src="../../assets/map-travel.jpg"
            alt=""
          />
        </div>
        <div class="even-img">
          <img
            class="personal-vacation"
            src="../../assets/map-travel.jpg"
            alt=""
          />
        </div>
        <div class="odd-img">
          <img
            class="personal-vacation"
            src="../../assets/map-travel.jpg"
            alt=""
          />
        </div>
      </aside>
    </div>
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
};
</script>

<style scoped>
/* travel experience container */
.exp-container {
  width: 65%;
  float: left;
}

.travel-container {
  height: 15rem;
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
}

.travel-experience {
  float: left;
}

.travel-destinations {
  float: left;
}

.profile-picture {
  height: 25rem;
  max-width: 100%;
}

.profile-picture img {
  max-height: 100%;
}

/* image container */
.img-container {
  float: right;
  width: 35%;
  padding-right: 3rem;
}

.even-img {
  text-align: left;
  margin: 1rem 0;
}

.odd-img {
  text-align: right;
  margin: 1rem 0;
}

.personal-vacation {
  height: 10rem;
}

aside {
  max-height: 100%;
}

/* general */

p {
  font-size: large;
}
</style>