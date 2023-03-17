angular.module('moduleControllers', []).
controller('CustomerController', function ($scope, $http, $location, $window) {
    $scope.cust = {};
    $scope.message = '';
    $scope.result = "color-default";
    $scope.isViewLoading = false;

  
   
        $scope.cars = {
            car01: { brand: "Ford", model: "Mustang", color: "red" },
            car02: { brand: "Fiat", model: "500", color: "white" },
            car03: { brand: "Volvo", model: "XC90", color: "black" }
    }
   
 
    
   
    //get called when user submits the form
    $scope.submitForm = function () {
        $scope.isViewLoading = true;
        console.log('Form is submitted with:', $scope.cust);

        //$http service that send or receive data from the remote server
        $http({
            method: 'POST',
            url: '/Home/CreateCustomer',
            data: $scope.cust
        }).success(function (data, status, headers, config) {
            $scope.errors = [];
            if (data.success === true) {
                $scope.cust = {};
                $scope.message = 'Form data Submitted!';
                $scope.result = "color-green";
                $location.path(data.redirectUrl);
                $window.location.reload();
            }
            else {
                $scope.errors = data.errors;
            }
        }).error(function (data, status, headers, config) {
            $scope.errors = [];
            $scope.message = 'Unexpected Error while saving data!!';
        });
        $scope.isViewLoading = false;
       
    }
})
    .controller('myCrtl', function ($scope) {
        $scope.products = ["Leche", "Pan", "Queso"];
        $scope.addItem = function () {
            $scope.errortext = "";
            if (!$scope.addMe) { return; }
            if ($scope.products.indexOf($scope.addMe) == -1) {
                $scope.products.push($scope.addMe);
            } else {
                $scope.errortext = "The item is already in your shopping list.";
            }
        }
        $scope.removeItem = function (x) {
            $scope.errortext = "";
            $scope.products.splice(x, 1);
        }
    })
.config(function ($locationProvider) {

    //default = 'false'
    $locationProvider.html5Mode(true);
})
.controller('timeController', function ($scope, $interval) {
    $scope.theTime = new Date().toLocaleTimeString();
    $interval(function () {
        $scope.theTime = new Date().toLocaleTimeString();
    }, 1000);
})
.controller('divController',["$scope","CalculatorService", function ($scope, CalculatorService) {
    $scope.divide = function () {
        $scope.result = CalculatorService.divide($scope.numero1, $scope.numero2);
    };
}]);


