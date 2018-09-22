function PlaceCreateController($scope, $state, $stateParams, SavoryTripManageService) {

    function place_empty_callback(response) {

        if (response.status != 1) {
            swal(response.message);
            return;
        }

        $scope.item = response.item;
    }

    function place_create_callback(response) {

        $scope.waiting = false;

        if (response.status != 1) {
            $scope.message = response.message;
            return;
        }

        $state.go('app.place-list');
    }

    $scope.confirmCreate = function () {

        $scope.waiting = true;
        $scope.message = null;

        var request = {};
        request.id = $scope.item.id;
        request.name = $scope.item.name;
        request.longitude = $scope.item.longitude;
        request.latitude = $scope.item.latitude;
        request.timeMachineId = $scope.item.timeMachineId;

        SavoryTripManageService.place_create(request).then(place_create_callback)
    }

    {
        SavoryTripManageService.place_empty({}).then(place_empty_callback);
    }
}
