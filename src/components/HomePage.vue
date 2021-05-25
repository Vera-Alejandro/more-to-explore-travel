<template>
  <div>
    <header>
      <h1>More To Explore Travel</h1>
    </header>
    <main>
      <VacationDestinations/>
      <v-divider></v-divider>

      <Welcome/>
      <v-divider></v-divider>

      <LetsGetInTouch/>
      <v-divider></v-divider>

      <div class="container"></div>
    </main>
  </div>
</template>

<script>
import Welcome from './Home/Welcome';
import LetsGetInTouch from './Home/LetsGetInTouch';
import VacationDestinations from './Home/VacationDestinations';


export default {
  name: "Home",
  components: {
    VacationDestinations,
    Welcome,
    LetsGetInTouch
  },
  data() {
    return {};
  },
};
</script>

<style>

img {
  max-height: 400px;
}

</style>