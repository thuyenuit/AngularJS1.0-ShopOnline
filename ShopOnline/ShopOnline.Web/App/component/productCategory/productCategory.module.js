/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('sms.productCategory', ['sms.common', 'scrollable-table']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('productCategories', {
                url: '/productCategories',
                templateUrl: '/app/component/productCategory/productCategoryListView.html',
                controller: 'productCategoryListController'
            })
            .state('productCategory-add', {
                url: '/productCategory-add',
                templateUrl: '/app/component/productCategory/productCategoryAddView.html',
                controller: 'productCategoryAddController'
            })
            .state('productCategory-edit', {
                url: '/productCategory-edit',
                templateUrl: '/app/component/productCategory/productCategoryEditView.html',
                controller: 'productCategoryEditController'
            });
    }
})();