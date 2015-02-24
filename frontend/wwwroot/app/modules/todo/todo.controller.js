(function () {
    'use strict';
    angular.module('todo').controller('TodoController', TodoController);

    TodoController.$inject = ['$http'];

    function TodoController($http) {
        var vm = this;

        vm.todos = [];
        vm.todoText = "";

        activate();

        function activate() {
            loadTodos();
        }

        vm.addTodo = function () {
            console.log(vm.todoText);
            $http.post('/api/todo', {Id: 0, Text: vm.todoText, Done: false})
                .success(function (data, status, headers, config) {
                    alert('Sucesso');
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });
            vm.todos.push({Text: vm.todoText, Done: false});
        }

        function loadTodos() {
            $http.get('/api/todo')
                .success(function (data, status, headers, config) {
                    console.log(data);
                    vm.todos = data;
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });
        }
    }
})();