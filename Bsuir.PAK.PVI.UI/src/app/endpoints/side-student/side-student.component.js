class SideStudentController {
	constructor($uibModal) {
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
		        'as as asasd fasfasf',
                'asf asf asf asf',
                'asf gas asf asgasf',
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