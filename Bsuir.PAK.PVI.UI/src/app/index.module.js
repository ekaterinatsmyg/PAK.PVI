/* global malarkey:false, toastr:false, moment:false */
import config from './index.config';
import runBlock from './index.run';

import shared from './shared/shared.module'
import api from './api/api.module';

import components from './shared/components/components.module';
import mainModule from './endpoints/index.module';

angular.module('front', [
        'parameters.config',
        'ngAnimate',
        'ngCookies',
        'ngTouch',
        'ngSanitize',
        'ngResource',
        'ui.router',
        'ui.bootstrap',
        'ui.select',
        'angular-cache',
        'angularFileUpload',
        'ui.sortable',
        'angular-svg-round-progressbar',
        'contenteditable',

        shared,
        components,
        api,
        mainModule
    ])
    .constant('localStorage', localStorage)
    .constant('toastr', toastr)
    .constant('moment', moment)

    .config(config)
    .run(runBlock)
;