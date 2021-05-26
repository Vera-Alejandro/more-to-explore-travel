<template>
  <div>
    <header>
      <h1>About Me</h1>
    </header>
    <main>
      <Introduction/>

      <v-divider></v-divider>
    </main>
  </div>
</template>

<script>
import Introduction from './About Me/Introduction';

export default {
  name: "AboutMe",
  components: {
    Introduction,
    },
    data: () => ({
      name: 'f',
    }),
  methods: {},
};
</script>

<style>


</style>