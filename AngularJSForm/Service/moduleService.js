angular.module('moduleService').factory('CalculatorService', function () {
    var service = {};

    service.divide = function (a, b) {
        return a / b;
    };

    return service;
});