
import sideAdminComponent from './side-admin.component' 
import routeConfig from './side-admin.route';

let endpoints =
    angular.module('admin', [])
        .config(routeConfig)
        .component('sideAdmin', sideAdminComponent)
;

export default endpoints = endpoints.name;