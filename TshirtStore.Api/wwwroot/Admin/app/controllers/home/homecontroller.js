(function() {
    'use strict';

    angular.module('mwa').controller('HomeController', HomeController);

    HomeController.$injector = ['$scope'];

    function HomeController($scope) {
        $scope.title = "meu home controller";


    }
})();