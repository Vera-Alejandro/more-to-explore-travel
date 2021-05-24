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
    message: '',
    };
  },
  async mounted() {
    // const text = await ( await fetch( "/api/TravelPageHTTPFunctions?name=Alejandro"));
    const { text } = await ( await fetch( "/api/TravelPageHTTPFunctions")).json();
    // eslint-disable-next-line no-debugger
    debugger;
    this.message = 'test';
    console.log(text);
  },
};
</script>

<style>
</style>