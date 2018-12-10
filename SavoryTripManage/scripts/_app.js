//Module
var app = angular.module('app', ['ngResource', 'ui.router', 'ui.bootstrap', 'ui.sortable']);

//Config
app.config(route);

//service
app.service('SavoryTripManageService', ['$resource', '$q', SavoryTripManageService]);

//directive
//app.directive('mappingtype', MappingTypeDirective);
//app.directive('keywordtype', KeywordTypeDirective);
