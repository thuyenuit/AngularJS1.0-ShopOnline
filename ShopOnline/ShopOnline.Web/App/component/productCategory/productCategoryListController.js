/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryListController', productCategoryListController)

    productCategoryListController.$inject = ['$scope', 'apiService', '$interval', '$mdEditDialog', '$filter'];

    function productCategoryListController($scope, apiService, $interval, $mdEditDialog, $filter) {
        // show
        $scope.options = [
            { name: 10, value: 10 },
            { name: 25, value: 25 },
            { name: 50, value: 50 },
            { name: 100, value: 100 }];
        $scope.valueShow = $scope.options[0].value;
        $scope.changeShow = function () {
            ListProductCategory();
        }      

        // list
        $scope.lstProductCategory = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.totalCount = 0;
        $scope.showFrom = 0;
        $scope.showTo = 0;

        $scope.ListProductCategory = ListProductCategory;
        function ListProductCategory(page) {
           
            $scope.loading = true;
            page = page || 0;
            var consfig = {
                params: {                   
                    page: page,
                    pageSize: $scope.valueShow
                }
            }
            var url = '/api/productcategory/getall';
            apiService.get(url, consfig, function (result) {
                $scope.lstProductCategory = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
                $scope.showFrom = result.data.ShowFrom;
                $scope.showTo = result.data.ShowTo;
                $scope.loading = false;
            }, function () {

            });
        }
        $scope.ListProductCategory();
        $scope.sortColumn = 'ProductCategoryName';
        $scope.reverse = false; // sắp xếp tăng dần 
        $scope.sortData = function (column)
        {
            if ($scope.sortColumn == column)
                $scope.reverse = !$scope.reverse;
            else
                $scope.reverse = false;
            $scope.sortColumn = column;
        }

        // select multi
        $scope.selectAll = selectAll;
        $scope.isAll = false;
        function selectAll() {
            if ($scope.isAll == false) {
                angular.forEach($scope.lstProductCategory, function (item) {
                    item.checked = true;
                });
                $scope.isAll = true;
            }
            else {
                angular.forEach($scope.lstProductCategory, function (item) {
                    item.checked = false;
                });
                $scope.isAll = false;
            }
        }

        // Lắng nghe sự thay đổi của lstProductCategory,
        // co 2 tham so: 1 - lang nghe ten bien lstProductCategory
        //               2 - function (new, old) va filter nhung gia tri moi la true thi vao danh sach da dc checked
        $scope.$watch("lstProductCategory", function (newCheck, old) {
            var checked = $filter("filter")(newCheck, { checked: true });
            if (checked.length) {
                $scope.selected = checked;
                $('#btnDeleteMulti').removeAttr('disabled');
            } else {
                $('#btnDeleteMulti').attr('disabled', 'disabled');
            }
        }, true);

    }
})(angular.module('sms.productCategory'));