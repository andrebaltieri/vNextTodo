(function(){
    'use strict';

    angular
        .module('todo.directives')
        .directive('todoCreateForm', todoCreateForm);

    function todoCreateForm() {
        var directive = {
            templateUrl: 'app/shared/todo-create/todo-create.view.html',
            restrict: 'E',
            link: link
        };
        return directive;

        function link(scope, el, attr, ctrl) {

        }
    }
})();