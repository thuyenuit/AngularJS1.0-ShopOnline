/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryAddController', productCategoryAddController);

    productCategoryAddController.$inject = ['$scope', 'apiService'];

    function productCategoryAddController($scope, apiService) {
        $scope.pcInfo = {};

        $scope.AddProductCategory = AddProductCategory;
        function AddProductCategory() {
            var url = 'productcategory/create';
            $scope.pcInfo.Status = true;
            $scope.pcInfo.CreateDate = new Date();
            apiService.post(url, $scope.pcInfo, function (result) {
                alert('Thêm thành công');
            }, function () {

            });
        }

    }
})(angular.module('sms.productCategory'));