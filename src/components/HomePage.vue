<template>
  <div>
    <header>
      <HomeHeader/>
    </header>
    <main>
      <VacationDestinations/>
      
      <v-divider></v-divider>
      <LetsGetInTouch/>

      <v-divider></v-divider>
      <InstagramFeed/>

      <v-divider></v-divider>
      <Welcome/>

    </main>
  </div>
</template>

<script>
import VacationDestinations from './Home/VacationDestinations';
import Welcome from './Home/Welcome';
import LetsGetInTouch from './Home/LetsGetInTouch';
import InstagramFeed from './Home/InstagramFeed';
import HomeHeader from './Home/HomeHeader';

export default {
  name: "Home",
  components: {
    HomeHeader,
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