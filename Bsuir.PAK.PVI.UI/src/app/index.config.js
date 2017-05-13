import {debugEnabled} from '../parameters.config';
import {pagesConstants} from './constants';

function config(toastr, $locationProvider, $urlRouterProvider) {
    'ngInject';

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: true
    });

    // Страница "по умолчанию"
    $urlRouterProvider.otherwise(pagesConstants.MAIN);

    // Конфигурация всплывающих сообщений
    toastr.options.closeButton = true;
    toastr.options.positionClass = 'toast-bottom-right';
}

export default config;
