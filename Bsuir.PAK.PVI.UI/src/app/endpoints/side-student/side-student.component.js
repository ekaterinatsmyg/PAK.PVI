class SideStudentController {
	constructor($uibModal, $interval, $timeout) {
		'ngInject';

		this.$uibModal = $uibModal;
		this.timeBetweenTest = null;

		this.runningTest = null;

		this.experiments = [
            {
                name: 'Эксперимент 1',
                tests: [
                    {name: 'Опыт 1'},
                    {name: 'Опыт 2'},
                    {name: 'Опыт 2'}
                ]
            },{
                name: 'Эксперимент 1',
                tests: [
                    {name: 'Опыт 1'},
                    {name: 'Опыт 2'},
                    {name: 'Опыт 2'}
                ]
            }
        ];

		this.test = {
		    stymulus: [
		        'ряд 1',
                'ряд 2',
                'ряд 3',
                'гамогенный'
            ]
        };
	}

	openExperimentSettings() {
	    let instance = this.$uibModal.open({
            component: 'experimentModalSettings'
        });

	    instance.result
            .then((time) => this.timeBetweenTest = time);
    }

    runTest(test) {
	    console.log(1)
	    this.runningTest = this.test;
    }

    finishTest(results) {
	    this.runningTest = null;
	    console.log(results);
    }
}

export default {
	template: require('./side-student.html'),
	controller: SideStudentController
};