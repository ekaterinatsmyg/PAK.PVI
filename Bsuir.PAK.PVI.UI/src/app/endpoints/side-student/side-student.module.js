import sideStudentComponent from './side-student.component' 
import routeConfig from './side-student.route';

let studentModule =
    angular.module('student', [])
        .config(routeConfig)
        .component('sideStudent', sideStudentComponent)
;

export default studentModule = studentModule.name;