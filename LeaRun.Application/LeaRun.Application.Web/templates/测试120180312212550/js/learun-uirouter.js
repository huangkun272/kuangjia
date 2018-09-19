angular.module('starter.uirouter', [])
.config(function ($stateProvider, $urlRouterProvider) {
$stateProvider
.state('tab', {
url: '/tab',
abstract: true,
templateUrl: 'templates/tabs.html',
controller: 'lrTabsCtrl'
}).state('tab132ec3d5-f1dd-b281-9992-6f3256c01189', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})
.state('tabb514a55d-6da7-84b4-7a5f-09db671949a1', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})
.state('tab3a1f1712-aed0-a69a-1d30-c4d1c7083dc3', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})
.state('tab6d8a5177-3082-8043-2f61-aa30437f5047', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})
.state('tab781cc4c6-4159-3530-ba33-dac74a0c2a9b', {
url: '/',
views: {
'tab-home': {
templateUrl: 'templates/.html'
}
}
})

$urlRouterProvider.otherwise('/')

