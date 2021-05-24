import Vue from 'vue';
import VueRouter from 'vue-router';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        name: 'App',
        component: () => import('@/components/HomePage.vue')
    }
]

const router = new VueRouter({
    routes
})

export default router