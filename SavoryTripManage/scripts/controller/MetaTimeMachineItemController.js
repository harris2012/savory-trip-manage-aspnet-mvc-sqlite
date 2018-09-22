function MetaTimeMachineItemController($scope, $state, $stateParams, SavoryTripManageService) {

    $scope.id = $stateParams.id;

    function meta_time_machine_item_callback(response) {

        $scope.loaded = true;
        if (response.status != 1) {
            return;
        }

        $scope.item = response.item;
    }

    {
        var request = {};
        request.id = $scope.id;

        SavoryTripManageService.meta_time_machine_item(request).then(meta_time_machine_item_callback);
    }
}
