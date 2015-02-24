(function(){
    'use strict';
    angular.module('todo').config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'TodoController',
                controllerAs: 'todo',
                templateUrl: 'app/modules/todo/todo.view.html'
            });
    });
})();