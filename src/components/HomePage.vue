<template>
  <div>
      <h1>More To Explore Travel</h1>
      <div><p>Travel More With Ellie B</p></div>
      <div><p>{{ message }}</p></div>
  </div>
</template>

<script>
export default {
  name: "Home",
  data() {
    return {
    message: 'no message from server yet',
    };
  },
  async mounted() {
    // eslint-disable-next-line no-debugger
    debugger;
    const { text } = await ( await fetch("/api/TravelPageHTTPFunctions")).json();
    this.message = text;
  },
};
</script>

<style>
</style>