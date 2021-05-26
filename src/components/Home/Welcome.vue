<template>
  <div class="welcome-container">
    <div class="text-cont">
      <h2>Welcome</h2>
      <article class="welcome-msg">
        <p>
          Lorem ipsum dolor sit amet, molestie enim, nec viverra sapien lacus in
          massa. Vivamus sodales, lacus mattis tincidunt efficitur, erat nibh
          accumsan ex, et ornare ex ligula ut turpis. Sed interdum placerat
          lacus, nec fermentum augue auctor et.
        </p>
      </article>
      <v-btn @click="inDevAlert = true">Get To Know Me!</v-btn>
    </div>
    <div class="img-cont">
      <aside class="welcome-img">
        <img src="../../assets/map-travel.jpg" alt="" />
      </aside>
    </div>

    <v-snackbar v-model="inDevAlert">
      'Getting To Know Me' feature is still in development.
      <template v-slot:action="{ attrs }">
        <v-btn color="green" text v-bind="attrs" @click="inDevAlert = false">
          Close
        </v-btn>
      </template>
    </v-snackbar>
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
};
</script>

<style>
.welcome-container {
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

.welcome-img {
  height: 25rem;
  max-width: 100%;
}

.welcome-img img {
  max-height: 100%;
}

aside {
  max-height: 100%;
}
</style>