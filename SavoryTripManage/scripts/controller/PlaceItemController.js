function PlaceItemController($scope, $state, $stateParams, SavoryTripManageService) {

    $scope.id = $stateParams.id;

    function place_item_callback(response) {

        $scope.loaded = true;
        if (response.status != 1) {
            return;
        }

        $scope.item = response.item;
    }

    {
        var request = {};
        request.id = $scope.id;

        SavoryTripManageService.place_item(request).then(place_item_callback);
    }
}
