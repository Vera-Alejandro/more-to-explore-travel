import Vue from 'vue';
import VueRouter from 'vue-router';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        name: 'Home',
        component: () => import('@/components/HomePage.vue')
    },
    {
        path: '/services',
        name: 'Services',
        component: () => import('@/components/Services.vue')
    },
    {
        path: '/aboutme',
        name: 'About Me',
        component: () => import('@/components/AboutMe.vue')
    },
    {
        path: '/blog',
        name: 'Blog',
        component: () => import('@/components/Blog.vue')
    },
    {
        path: '/contact',
        name: 'Contact',
        component: () => import('@/components/Contact.vue')
    },
]

const router = new VueRouter({
    mode: 'history',
    routes
})

export default router