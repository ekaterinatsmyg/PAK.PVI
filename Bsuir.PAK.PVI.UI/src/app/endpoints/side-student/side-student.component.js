class SideStudentController {
	constructor($uibModal) {
		'ngInject';

		this.$uibModal = $uibModal;
		console.log($uibModal)
		// console.log(Modal)
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
	}

	openExperimentSettings() {
	    let instance = this.$uibModal.open({
            component: 'experimentModalSettings'
        });

	    instance.result
            .then(result => console.log(result))
        // this.Modal.open({
        //     templateUrl: './app/endpoints/side-student/experiment-modal-settings/experiment-modal-settings.html',
        // }).then((result) => console.log('save'));
    }
}

export default {
	template: require('./side-student.html'),
	controller: SideStudentController
};