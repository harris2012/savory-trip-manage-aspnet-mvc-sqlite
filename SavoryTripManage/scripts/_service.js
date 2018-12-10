function SavoryTripManageService($resource, $q) {

    var resource = $resource('api/search-support', {}, {

        place_items: { method: 'POST', url: 'api/place/items' },
        place_item: { method: 'POST', url: 'api/place/item' },
        place_count: { method: 'POST', url: 'api/place/count' },
        place_update: { method: 'POST', url: 'api/place/update' },
        place_enable: { method: 'POST', url: 'api/place/enable' },
        place_disable: { method: 'POST', url: 'api/place/disable' },
        place_create: { method: 'POST', url: 'api/place/create' },
        place_editable: { method: 'POST', url: 'api/place/editable' },
        place_empty: { method: 'POST', url: 'api/place/empty' },

        meta_time_machine_items: { method: 'POST', url: 'api/meta-time-machine/items' },
        meta_time_machine_item: { method: 'POST', url: 'api/meta-time-machine/item' },
        meta_time_machine_count: { method: 'POST', url: 'api/meta-time-machine/count' },
        meta_time_machine_update: { method: 'POST', url: 'api/meta-time-machine/update' },
        meta_time_machine_enable: { method: 'POST', url: 'api/meta-time-machine/enable' },
        meta_time_machine_disable: { method: 'POST', url: 'api/meta-time-machine/disable' },
        meta_time_machine_create: { method: 'POST', url: 'api/meta-time-machine/create' },
        meta_time_machine_editable: { method: 'POST', url: 'api/meta-time-machine/editable' },
        meta_time_machine_empty: { method: 'POST', url: 'api/meta-time-machine/empty' },

        user_profile: { method: 'POST', url: 'api/user/profile' }
    });

    return {

        place_items: function (request) { var d = $q.defer(); resource.place_items({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_item: function (request) { var d = $q.defer(); resource.place_item({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_update: function (request) { var d = $q.defer(); resource.place_update({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_count: function (request) { var d = $q.defer(); resource.place_count({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_enable: function (request) { var d = $q.defer(); resource.place_enable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_disable: function (request) { var d = $q.defer(); resource.place_disable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_create: function (request) { var d = $q.defer(); resource.place_create({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_editable: function (request) { var d = $q.defer(); resource.place_editable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        place_empty: function (request) { var d = $q.defer(); resource.place_empty({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },

        meta_time_machine_items: function (request) { var d = $q.defer(); resource.meta_time_machine_items({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_item: function (request) { var d = $q.defer(); resource.meta_time_machine_item({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_update: function (request) { var d = $q.defer(); resource.meta_time_machine_update({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_count: function (request) { var d = $q.defer(); resource.meta_time_machine_count({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_enable: function (request) { var d = $q.defer(); resource.meta_time_machine_enable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_disable: function (request) { var d = $q.defer(); resource.meta_time_machine_disable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_create: function (request) { var d = $q.defer(); resource.meta_time_machine_create({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_editable: function (request) { var d = $q.defer(); resource.meta_time_machine_editable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        meta_time_machine_empty: function (request) { var d = $q.defer(); resource.meta_time_machine_empty({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },

        user_profile: function () { var d = $q.defer(); resource.user_profile({}, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; }
    }
}
