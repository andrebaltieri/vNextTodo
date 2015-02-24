(function(){
    'use strict';

    angular
        .module('todo.directives')
        .directive('todoList', todoList);

    function todoList() {
        var directive = {
            templateUrl: 'app/shared/todo-list/todo-list.view.html',
            restrict: 'E',
            link: link
        };
        return directive;

        function link(scope, el, attr, ctrl) {

        }
    }
})();
