(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
    function ($stateProvider, $urlRouterProvider, $) {
        $urlRouterProvider.otherwise('/');

        if (abp.auth.hasPermission('Pages.Users')) {
            $stateProvider
                .state('users', {
                    url: '/users',
                    templateUrl: '/App/Main/views/users/index.cshtml',
                    menu: 'Users' //Matches to name of 'Users' menu in TrainerNavigationProvider,
                })
                .state('users.detail', {
                    url: '/{userId}',
                    controller: ('app.views.users.updateUser', ['$scope', '$stateParams', '$filter', 'abp.services.app.user', function ($scope, $stateParams, $filter, userService) {
                        //$scope.userSelect = $scope.vm.users[0];
                        console.log($scope.vm.users);
                        $scope.userSelect = $filter('filter')($scope.vm.users, function (d) { return d.id == $stateParams.userId; })[0];
                        $scope.userSelect.save = function () {
                            userService.updateUser($scope.userSelect)
                                .success(function () {
                                    abp.notify.info(App.localize('UpdatedSuccessfully'));
                                });
                        };
                    }]),
                    templateUrl: '/App/Main/views/users/users.detail.cshtml'
                });
            $urlRouterProvider.otherwise('/users');
        }
        //$stateProvider
        //       .state('test', {
        //           url: '/users/{userId}',
        //           templateUrl: '/App/Main/views/users/users.detail.cshtml'
        //       });
        if (abp.auth.hasPermission('Pages.Tenants')) {
            $stateProvider
                .state('tenants', {
                    url: '/tenants',
                    templateUrl: '/App/Main/views/tenants/index.cshtml',
                    menu: 'Tenants' //Matches to name of 'Tenants' menu in TrainerNavigationProvider
                });
            $urlRouterProvider.otherwise('/tenants');
        }

        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/App/Main/views/home/home.cshtml',
                menu: 'Home' //Matches to name of 'Home' menu in TrainerNavigationProvider
            })
            .state('about', {
                url: '/about',
                templateUrl: '/App/Main/views/about/about.cshtml',
                menu: 'About' //Matches to name of 'About' menu in TrainerNavigationProvider
            });
    }
    ]);
})();