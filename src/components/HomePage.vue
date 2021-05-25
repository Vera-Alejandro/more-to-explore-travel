<template>
  <div>
    <header>
      <h1>More To Explore Travel</h1>
    </header>
    <main>
      <div class="img-container vacation-types">
        <img class="vacation-type-img" src="../assets/map-travel.jpg" alt="" />
        <img class="vacation-type-img" src="../assets/map-travel.jpg" alt="" />
        <img class="vacation-type-img" src="../assets/map-travel.jpg" alt="" />
      </div>

      <div class="container welcome-container">
        <div class="text-cont">
          <h2>Welcome</h2>
          <article class="welcome-msg">
            <p>
              Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien
              lacus in massa. Vivamus sodales, lacus mattis tincidunt efficitur,
              erat nibh accumsan ex, et ornare ex ligula ut turpis. Sed interdum
              placerat lacus, nec fermentum augue auctor et.
            </p>
          </article>
          <v-btn>Get To Know Me!</v-btn>
        </div>
        <div class="img-cont">
          <aside class="welcome-img">
            <img src="../assets/map-travel.jpg" alt="" />
          </aside>
        </div>
      </div>
      <div class="container"></div>
      <div class="container"></div>
    </main>
  </div>
</template>

<script>
export default {
  name: "Home",
  data() {
    return {};
  },
};
</script>

<style>
.img-container {
  display: flex;
  margin: 2rem;
  justify-content: space-around;
}

.vacation-types {
  height: 17rem;
}

.vacation-type-img {
  height: 100%;
}

.welcome-container {
  height: 15rem;
  margin: 1rem;
  clear: both;
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

.welcome-img {
  height: 25rem;
}

.welcome-img img {
  max-height: 100%;
}

aside {
  max-height: 100%;
}

img {
  max-height: 400px;
}
</style>