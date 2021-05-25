<template>
  <div class="img-container vacation-types">
    <img class="vacation-type-img" src="../../assets/map-travel.jpg" alt="" />
    <img class="vacation-type-img" src="../../assets/map-travel.jpg" alt="" />
    <img class="vacation-type-img" src="../../assets/map-travel.jpg" alt="" />
  </div>
</template>

<script>
export default {
        name: 'LetsGetInTouch',
    data () {
        return {

        };
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
</style>