import config from './api.config';
import UserManager from './services/UserManager.service';

let api = angular
    .module('api', ['ng-rest-api'])
    .config(config)
    .service('UserManager', UserManager)
    ;

export default api = api.name;
