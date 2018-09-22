var route = function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.when('', '/welcome').when('/', '/welcome');

    $stateProvider.state('app', {
        url: '/',
        views: {
            'header': { templateUrl: 'scripts/view/view_header.html?v=' + window.releaseNo, controller: HeaderController },
            'main-menu': { templateUrl: 'scripts/view/view_menu.html?v=' + window.releaseNo},
            'main-body': { template: '<div ui-view></div>' }
        }
    });

    $stateProvider.state('app.welcome', { url: 'welcome', templateUrl: 'scripts/view/view_welcome.html?v=' + window.releaseNo });

    $stateProvider.state('app.place-list', { url: 'place-list', templateUrl: 'scripts/view/view_place_list.html?v=' + window.releaseNo, controller: PlaceListController });
    $stateProvider.state('app.place-item', { url: 'place-item/:id', templateUrl: 'scripts/view/view_place_item.html?v=' + window.releaseNo, controller: PlaceItemController });
    $stateProvider.state('app.place-create', { url: 'place-create', templateUrl: 'scripts/view/view_place_create.html?v=' + window.releaseNo, controller: PlaceCreateController });
    $stateProvider.state('app.place-update', { url: 'place-update/:id', templateUrl: 'scripts/view/view_place_update.html?v=' + window.releaseNo, controller: PlaceUpdateController });

    $stateProvider.state('app.otherwise', {
        url: '*path',
        templateUrl: 'views/view_404.html?v=' + window.releaseNo
    });
}