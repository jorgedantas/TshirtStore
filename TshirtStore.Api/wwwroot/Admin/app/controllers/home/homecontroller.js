(function() {
    'use strict';

    angular.module('mwa').controller('HomeController', HomeController);

    HomeController.$injector = [];

    function HomeController() {
        var vm = this;
        vm.title = "meu home controller";
       
        activate();

        function activate() {
            
        }

    }
})();