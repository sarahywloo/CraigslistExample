namespace CraigslistExample {

    angular.module("CraigslistExample", ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {
            //$routeProvider.when('/', {
            // templateUrl: '/path/to/view',
            // controller: CraigslistExample.Controllers.ControllerClass,
            // controllerAs: 'views variable name for controller'
            //});
            $routeProvider.when('/', {
                template: 'Hello World!'
            })
            $routeProvider.when('/listings', {
                templateUrl: '/ngApp/views/listListings.html',
                controller: CraigslistExample.Controllers.listOfListingsController,
                controllerAs: 'listingsController' 
            });
        });
}