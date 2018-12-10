function MetaTimeMachineCreateController($scope, $state, $stateParams, SavoryTripManageService) {

    function meta_time_machine_empty_callback(response) {

        if (response.status != 1) {
            swal(response.message);
            return;
        }

        $scope.item = response.item;
    }

    function meta_time_machine_create_callback(response) {

        $scope.waiting = false;

        if (response.status != 1) {
            $scope.message = response.message;
            return;
        }

        $state.go('app.meta-time-machine-list');
    }

    $scope.confirmCreate = function () {

        $scope.waiting = true;
        $scope.message = null;

        var request = {};
        request.id = $scope.item.id;
        request.timeMachineId = $scope.item.timeMachineId;
        request.timeMachineName = $scope.item.timeMachineName;

        SavoryTripManageService.meta_time_machine_create(request).then(meta_time_machine_create_callback)
    }

    {
        SavoryTripManageService.meta_time_machine_empty({}).then(meta_time_machine_empty_callback);
    }
}
