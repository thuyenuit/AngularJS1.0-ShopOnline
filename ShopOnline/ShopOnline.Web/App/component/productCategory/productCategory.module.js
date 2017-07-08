/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('sms.productCategory', ['sms.common', 'scrollable-table']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('productCategories', {
                url: '/list-product-category',
                templateUrl: '/app/component/productCategory/productCategoryListView.html',
                controller: 'productCategoryListController'
            })
            .state('productCategory-add', {
                url: '/add-product-category',
                templateUrl: '/app/component/productCategory/productCategoryAddView.html',
                controller: 'productCategoryAddController'
            })
            .state('productCategoryEdit', {
                url: '/edit-product-category?categoryId',
                templateUrl: '/app/component/productCategory/productCategoryEditView.html',
                controller: 'productCategoryEditController'
            })
            .state('productCategoryView', {
                url: '/view-product-category?categoryId',
                templateUrl: '/app/component/productCategory/productCategoryViewDetailView.html',
                controller: 'productCategoryViewDetailController'
            });
    }
})();