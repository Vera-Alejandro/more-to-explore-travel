<template>
  <div class="p-0 block container mx-auto md:flex">
    <div 
    v-for="vaca in vacationPhotos"
    :key="vaca.textOverlay"
    class="inline-block">
      <img
        :src="vaca.imgSrc"
        :alt="vaca.textOverlay"
        :title="vaca.textOverlay"
        class=""
      />
      <div>
        <h1 class="absolute text-lg -mt-16 text-white px-4"> {{ vaca.textOverlay }} </h1>
      </div>
    </div>
    
  </div>
</template>

<script>
export default {
  name: "VacationDestination",
  data: () => ({
    vacationPhotos: [
      {
        textOverlay: "Romantic Retreats",
        imgSrc: "https://moretoexploreapistorage.blob.core.windows.net/site-images/seaside-drinks.jpg",
      },
      {
        textOverlay: "Family Destinations",
        imgSrc: "https://moretoexploreapistorage.blob.core.windows.net/site-images/beach.jpg",
      },
      {
        textOverlay: "Group Getaway",
        imgSrc: "https://moretoexploreapistorage.blob.core.windows.net/site-images/friend-vacation.jpg",
      },
    ]
  }),
};
</script>

<style>
</style>