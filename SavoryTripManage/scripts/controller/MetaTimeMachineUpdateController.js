//新建数据库
function MetaTimeMachineUpdateController($scope, $state, $stateParams, SavoryTripManageService) {

    $scope.id = $stateParams.id;

    function meta_time_machine_editable_callback(response) {

        $scope.loaded = true;
        if (response.status != 1) {
            return;
        }

        $scope.item = response.item;
    }

    function meta_time_machine_update_callback(response) {
        if (response.status != 1) {
            swal(response.message);
            return;
        }

        $state.go('app.meta-time-machine-item', { id: $scope.id });
    }

    $scope.confirmUpdate = function () {

        $scope.waiting = true;
        $scope.message = null;

        var request = {};
        request.id = $scope.item.id;
        request.timeMachineId = $scope.item.timeMachineId;
        request.timeMachineName = $scope.item.timeMachineName;

        SavoryTripManageService.meta_time_machine_update(request).then(meta_time_machine_update_callback)
    }

    {
        var request = {};
        request.id = $scope.id;

        SavoryTripManageService.meta_time_machine_editable(request).then(meta_time_machine_editable_callback);
    }
}
