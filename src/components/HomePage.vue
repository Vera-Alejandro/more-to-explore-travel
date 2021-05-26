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
      <InstagramFeed/>

    </main>
  </div>
</template>

<script>
import Welcome from './Home/Welcome';
import LetsGetInTouch from './Home/LetsGetInTouch';
import VacationDestinations from './Home/VacationDestinations';
import InstagramFeed from './Home/InstagramFeed';

export default {
  name: "Home",
  components: {
    VacationDestinations,
    Welcome,
    LetsGetInTouch,
    InstagramFeed
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