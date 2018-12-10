function PlaceListController($scope, $state, $stateParams, SavoryTripManageService) {

    function place_items_callback(response) {

        $scope.items_loaded = true;

        if (response.status !== 1) {
            $scope.items_message = response.message;
            return;
        }

        $scope.items = response.items;
    }

    function place_count_callback(response) {

        $scope.count_loaded = true;
        if (response.status !== 1) {
            $scope.count_message = response.message;
            return;
        }

        $scope.totalCount = response.totalCount;
    }

    $scope.pageChanged = function () {

        $scope.items_loaded = false;
        $scope.items_message = null;

        var request = {};

        request.pageIndex = $scope.currentPage;

        SavoryTripManageService.place_items(request).then(place_items_callback);
    }

    {
        $scope.maxSize = 10;
        $scope.currentPage = 1;
        $scope.pageSize = 20;

        SavoryTripManageService.place_count({}).then(place_count_callback);
        SavoryTripManageService.place_items({pageIndex: $scope.currentPage}).then(place_items_callback);
    }

}
