(function() {
    "use strict";

    angular.module(angular._Module_)
        .controller("fohmCtrl",["$scope", "$http", function($scope, $http) {
            $scope.mvcValue = $scope.mvcValue || window.mvcValue;

                    $scope.Add = function() {
                        var data = {
                            value: $scope.mvcValue
                        };

                        $http.post('/add', data).
                            then(function successCallback(response) {
                                    $scope.mvcValue = response.data;
                                },
                            function errorCallback(response) {
                                console.log("error while adding a number");
                            });
                    }

                    $scope.Sub = function(value) {
                        var data = {
                            value: $scope.mvcValue
                        };

                        $http.post('/sub', data).
                            then(function successCallback(response) {
                                    $scope.mvcValue = response.data;
                                },
                                function errorCallback(response) {
                                    console.log("error while removing a number");
                                });
                    }
                }
            ]);
}());