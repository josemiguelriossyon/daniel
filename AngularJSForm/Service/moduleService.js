angular.module('moduleService', []).factory('calculatorService', function () {
    var service = {};

    service.divide = function (a, b) {
        return a / b;
    };

    return service;
});