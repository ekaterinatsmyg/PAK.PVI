// Services
import AuthInterceptor from  './services/auth/auth.interceptor';
import AlertResponse from './services/AlertResponse/AlertResponse.service';


let sharedComponents = angular.module('shared-components', [
        'pascalprecht.translate'
    ])
        .constant('alert', swal)
        .service('AuthInterceptor', AuthInterceptor)
        .service('AlertResponse', AlertResponse)
    ;

export default sharedComponents = sharedComponents.name;

