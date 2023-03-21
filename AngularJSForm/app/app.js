var app = angular.module("myApp", [
    'moduleControllers',
	'moduleService',
	'ngRoute'
   
]).
	config(['$routeProvider', function ($routeProvider) {
		$routeProvider.
			when("/drivers", { templateUrl: "partials/drivers.html", controller: "driversController" }).
			when("/drivers/:id", { templateUrl: "partials/driver.html", controller: "driverController" }).
			when("/formulario", { templateUrl: "Views/Home/formulario.cshtml", controller: "CustomerController" }).
			when("/ejemplo", { templateUrl: "Views/Home/ejemplo.cshtml", controller: "CustomerController" }).
			when("/calculadora", { templateUrl: "Views/Home/calculadora.cshtml", controller: "divController" }).
			when("/seleccionCoche", { templateUrl: "Views/Home/seleccionCoche.cshtml", controller: "CustomerController" }).
			when("/reloj", { templateUrl: "Views/Home/reloj.cshtml", controller: "timeController" }).
			when("/formula1", { templateUrl: "Views/Home/formula1.cshtml", controller: "driversController" }).
			when("/carritoCompra", { templateUrl: "Views/Home/carritoCompra.cshtml", controller: "myCrtl" }).
			otherwise({ redirectTo: '/drivers' });
	}]);