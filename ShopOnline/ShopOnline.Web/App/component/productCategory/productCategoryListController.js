/// <reference path="/Assets/Admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.lstProductCategory = [];
        $scope.visibleProjects = [{
            facility: "Atlanta",
            code: "C-RD34",
            cost: 540000,
            conditionRating: 52,
            extent: 100,
            planYear: 2014
        }, {
            facility: "Seattle",
            code: "CRDm-4",
            cost: 23000,
            conditionRating: 40,
            extent: 88,
            planYear: 2014
        }, {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Austin",
            code: "GR-5",
            cost: 1200000,
            conditionRating: 92,
            extent: 90,
            planYear: 2014
        },
        {
            facility: "Dayton",
            code: "LY-7",
            cost: 123000,
            conditionRating: 71,
            extent: 98,
            planYear: 2014
        }, {
            facility: "Portland",
            code: "Dm-4",
            cost: 149000,
            conditionRating: 89,
            extent: 77,
            planYear: 2014
        }, {
            facility: "Dallas",
            code: "AW-3",
            cost: 14000,
            conditionRating: 89,
            extent: 79,
            planYear: 2014
        }, {
            facility: "Houston",
            code: "Dm-4",
            cost: 1100000,
            conditionRating: 93,
            extent: 79,
            planYear: 2014
        }, {
            facility: "Boston",
            code: "DD3",
            cost: 1940000,
            conditionRating: 86,
            extent: 80,
            planYear: 2015
        }, {
            facility: "New York",
            code: "ER1",
            cost: 910000,
            conditionRating: 87,
            extent: 82,
            planYear: 2015
        }];

        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.totalCount = 0;     

        $scope.ListProductCategory = ListProductCategory;
        function ListProductCategory(page) {
            page = page || 0;
            var consfig = {
                params: {                   
                    page: page,
                    pageSize: 5
                }
            }
            var url = 'productcategory/getall';
            apiService.get(url, consfig, function (result) {
                $scope.lstProductCategory = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {

            });
        }
        $scope.ListProductCategory();

        $scope.facilities = [];
        for (var i = 0; i < $scope.lstProductCategory.length; i++) {
            $scope.facilities.push($scope.lstProductCategory[i].ProductCatgoryID);
        }

       /* $scope.$watch('selected', function (fac) {
            $scope.$broadcast("rowSelected", fac);
        });*/

    }
})(angular.module('sms.productCategory'));