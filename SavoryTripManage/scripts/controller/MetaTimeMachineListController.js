function MetaTimeMachineListController($scope, $state, $stateParams, SavoryTripManageService) {

    function meta_time_machine_items_callback(response) {

        $scope.items_loaded = true;

        if (response.status !== 1) {
            $scope.items_message = response.message;
            return;
        }

        $scope.items = response.items;
    }

    function meta_time_machine_count_callback(response) {

        $scope.count_loaded = true;
        if (response.status !== 1) {
            $scope.count_message = response.message;
            return;
        }

        $scope.totalCount = response.totalCount;
    }

    //分页
    $scope.pageChanged = function () {

        $scope.items_loaded = false;
        $scope.items_message = null;

        var request = {};

        request.pageIndex = $scope.currentPage;

        SavoryTripManageService.meta_time_machine_items(request).then(meta_time_machine_items_callback);
    };

    {
        $scope.maxSize = 10;
        $scope.currentPage = 1;
        $scope.pageSize = 20;

        SavoryTripManageService.meta_time_machine_count({}).then(meta_time_machine_count_callback);
        SavoryTripManageService.meta_time_machine_items({pageIndex: $scope.currentPage}).then(meta_time_machine_items_callback);
    }

}
