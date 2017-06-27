/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('sms',
        ['sms.productCategory','sms.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider, $locationProvider) {
        $stateProvider
            .state('home', {
                url: '/admin',
                templateUrl: '/app/component/home/homeView.html',
                controller: 'homeController'
            });
        $urlRouterProvider.otherwise('/admin');
       // $locationProvider.html5Mode(true);
        //$locationProvider.hashPrefix('!');
    }
})();