<template>
  <div class="img-group-container">
    <div class="img-container">
      <img
        class="vacation-type-img"
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/seaside-drinks.PNG"
        alt=""
      />
      <p class="center-title">Romantic Getaway</p>
    </div>
    
    <div class="img-container">
      <img
        class="vacation-type-img"
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/beach.PNG"
        alt=""
      />
      <p class="center-title">Family Adventures</p>
    </div>

    <div class="img-container">
      <img
        class="vacation-type-img"
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/friend-vacation.PNG"
        alt=""
      />
      <p class="center-title">Group Travel</p>
    </div>
  </div>
</template>

<script>
export default {
  name: "VacationDestination",
  data: () => ({
    
  }),
};
</script>

<style>
.img-group-container {
  display: inline-flex;
  justify-content: space-around;
  height: 20rem;
  margin: 0 2rem;
}

.img-container {
  padding: 1rem 2rem;
  position: relative;
}

.vacation-type-img{
  height: 100%;
  width: 100%;
}

.center-title{
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);


  color: whitesmoke;
  background-color: grey;
  font-size: 1.75rem;
  font-family: "Satisfy", cursive;
}
</style>