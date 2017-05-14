import sideStudentComponent from './side-student.component';
import experimentModalSettingsComponent from './experiment-modal-settings/experiment-modal-settings.component';
import routeConfig from './side-student.route';

let studentModule =
    angular.module('student', [])
        .config(routeConfig)
        .component('sideStudent', sideStudentComponent)
        .component('experimentModalSettings', experimentModalSettingsComponent)
;

export default studentModule = studentModule.name;