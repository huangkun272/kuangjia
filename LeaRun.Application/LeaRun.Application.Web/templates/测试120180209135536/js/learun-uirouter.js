angular.module('starter.uirouter', [])
.config(function ($stateProvider, $urlRouterProvider) {
$stateProvider
.state('tab', {
url: '/tab',
abstract: true,
templateUrl: 'templates/tabs.html',
controller: 'lrTabsCtrl'
}).state('tab3a1f1712-aed0-a69a-1d30-c4d1c7083dc3', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})
.state('tab584cac74-15dd-c9b7-966c-7a30677864e3', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})
.state('tab6add37bc-6692-6b7c-e0cf-61aebe494124', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})

$urlRouterProvider.otherwise('/')

