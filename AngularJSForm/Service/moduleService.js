angular.module('moduleService', []).factory('calculatorService', function () {
    var service = {};

    service.divide = function (a, b) {
        return a / b;
    };

    return service;
})
    .factory('f1Service', function ($http) {

    var ergastAPI = {};

    ergastAPI.getDrivers = function () {
        return $http({
            method: 'JSONP',
            url: 'http://ergast.com/api/f1/2022/driverStandings.json?callback=JSON_CALLBACK'
        });
    }

    return ergastAPI;
});


