/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryAddController', productCategoryAddController);

    productCategoryAddController.$inject = [
                                            '$scope',
                                            'apiService',
                                            'commonService',
                                            '$state',
                                            'notificationService'];

    function productCategoryAddController($scope, apiService, commonService, $state, notificationService) {
        $scope.pcInfo = {};

        $scope.GetSEOTitle = GetSEOTitle;
        function GetSEOTitle() {
            $scope.pcInfo.ProductCategoryAlias = commonService.getSeoTitle($scope.pcInfo.ProductCategoryName);
        }

        //angular.element("input").on('focus', function () {
        //    $(this).css("background-color", "#EEE9E9");
        //}).on('focusout', function () {
        //    $(this).css("background-color", "");
        //});

        $scope.AddProductCategory = AddProductCategory;
        function AddProductCategory() {
            var url = '/api/productcategory/create';
            $scope.pcInfo.Status = true;
            $scope.pcInfo.CreateDate = new Date();
            apiService.post(url, $scope.pcInfo, function (result) {               
                notificationService.displaySuccess('Thêm mới thành công.');
               // $state.go('productCategories');
            }, function () {
                notificationService.displayError('Thêm mới thất bại. Vui lòng kiểm tra lại!');
            });
        }

    }
})(angular.module('sms.productCategory'));