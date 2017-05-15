import sideStudentComponent from './side-student.component';
import executeTestComponent from './execute-test/execute-test.component';
import experimentModalSettingsComponent from './experiment-modal-settings/experiment-modal-settings.component';
import routeConfig from './side-student.route';

let studentModule =
    angular.module('student', [])
        .config(routeConfig)
        .component('sideStudent', sideStudentComponent)
        .component('experimentModalSettings', experimentModalSettingsComponent)
        .component('executeTest', executeTestComponent)
;

export default studentModule = studentModule.name;