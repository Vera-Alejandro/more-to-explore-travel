<template>
  <div class="img-group-container">
    <div class="img-container">
      <img
        class="vacation-type-img"
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/seaside-drinks.jpg"
        alt=""
      />
      <p class="center-title">Romantic Getaway</p>
    </div>
    
    <div class="img-container">
      <img
        class="vacation-type-img"
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/beach.jpg"
        alt=""
      />
      <p class="center-title">Family Adventures</p>
    </div>

    <div class="img-container">
      <img
        class="vacation-type-img"
        src="https://moretoexploreapistorage.blob.core.windows.net/site-images/friend-vacation.jpg"
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
  filter: brightness(85%);
}

.center-title{
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  padding: 20px;
  text-align: center;

  color: whitesmoke;
  font-size: 1.75rem;
  font-family: "Satisfy", cursive;
}

@media screen and (max-width: 600px) {
  .img-group-container {
    display: contents;
  }
}

</style>