import mainComponent from './index.component' 
import routeConfig from './index.route';
import studentModule from './side-student/side-student.module';
import adminModule from './side-admin/side-admin.module';

let mainModule =
    angular.module('main', [
        studentModule,
        adminModule
    ])
        .config(routeConfig)
        .component('pakMain', mainComponent)
;

export default mainModule = mainModule.name;