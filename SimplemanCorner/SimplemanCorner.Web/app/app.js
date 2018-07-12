(function () {
    angular.module('simplemancorner',
        ['simplemancorner.products'],
        ['simplemancorner.product_categories'],
        ['simplemancorner.common'])

        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})