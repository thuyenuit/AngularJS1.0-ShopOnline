/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryEditController', productCategoryEditController);

    productCategoryEditController.$inject = [
                                            '$scope',
                                            'apiService',
                                            'commonService',
                                            '$stateParams',
                                            '$state',
                                            'notificationService'];

    function productCategoryEditController($scope, apiService, commonService, $stateParams, $state, notificationService) {
        $scope.pcInfo = {};

        $scope.GetSEOTitle = GetSEOTitle;
        function GetSEOTitle() {
            $scope.pcInfo.ProductCategoryAlias = commonService.getSeoTitle($scope.pcInfo.ProductCategoryName);
        }
        // thong tin the loai
        $scope.LoadCategoryInfo = LoadCategoryInfo;
        function LoadCategoryInfo() {
            var consfig = {
                params: {
                    categoryId: $stateParams.categoryId
                }
            }
            var url = '/api/productcategory/getbyid';
            apiService.get(url, consfig, function (result) {
                $scope.pcInfo = result.data;
            }, function () {
                notificationService.displayError('Không tìm thấy thông tin thể loại! Vui lòng kiểm tra lại');
            })
        }
        LoadCategoryInfo();

        //cap nhat
        $scope.UpdateProductCategory = UpdateProductCategory;
        function UpdateProductCategory() {
            var url = '/api/productcategory/update';
            apiService.post(url, $scope.pcInfo, function (result) {
                notificationService.displaySuccess('Cập nhật thành công.');
            }, function () {
                notificationService.displayError('Cập nhật thất bại. Vui lòng kiểm tra lại!');
            });
        }

    }
})(angular.module('sms.productCategory'));