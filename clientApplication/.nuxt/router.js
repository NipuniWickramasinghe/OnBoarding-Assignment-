import Vue from 'vue'
import Router from 'vue-router'
import { normalizeURL, decode } from 'ufo'
import { interopDefault } from './utils'
import scrollBehavior from './router.scrollBehavior.js'

const _7c5be202 = () => interopDefault(import('..\\pages\\Accountbackup.vue' /* webpackChunkName: "pages/Accountbackup" */))
const _58284964 = () => interopDefault(import('..\\pages\\AccountDetailsPage.vue' /* webpackChunkName: "pages/AccountDetailsPage" */))
const _665d7e0c = () => interopDefault(import('..\\pages\\BillingPage.vue' /* webpackChunkName: "pages/BillingPage" */))
const _99be9e86 = () => interopDefault(import('..\\pages\\ShippingPage.vue' /* webpackChunkName: "pages/ShippingPage" */))
const _39815c42 = () => interopDefault(import('..\\pages\\index.vue' /* webpackChunkName: "pages/index" */))

const emptyFn = () => {}

Vue.use(Router)

export const routerOptions = {
  mode: 'history',
  base: '/',
  linkActiveClass: 'nuxt-link-active',
  linkExactActiveClass: 'nuxt-link-exact-active',
  scrollBehavior,

  routes: [{
    path: "/Accountbackup",
    component: _7c5be202,
    name: "Accountbackup"
  }, {
    path: "/AccountDetailsPage",
    component: _58284964,
    name: "AccountDetailsPage"
  }, {
    path: "/BillingPage",
    component: _665d7e0c,
    name: "BillingPage"
  }, {
    path: "/ShippingPage",
    component: _99be9e86,
    name: "ShippingPage"
  }, {
    path: "/",
    component: _39815c42,
    name: "index"
  }],

  fallback: false
}

export function createRouter (ssrContext, config) {
  const base = (config._app && config._app.basePath) || routerOptions.base
  const router = new Router({ ...routerOptions, base  })

  // TODO: remove in Nuxt 3
  const originalPush = router.push
  router.push = function push (location, onComplete = emptyFn, onAbort) {
    return originalPush.call(this, location, onComplete, onAbort)
  }

  const resolve = router.resolve.bind(router)
  router.resolve = (to, current, append) => {
    if (typeof to === 'string') {
      to = normalizeURL(to)
    }
    return resolve(to, current, append)
  }

  return router
}
