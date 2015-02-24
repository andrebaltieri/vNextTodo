(function(){
	'use strict';
	angular.module('todo').controller('TodoController', TodoController);

	TodoController.$inject = ['$location'];

	function TodoController($location) {
		var vm = this;

		activate();

        function activate() {
        }
	}
})();