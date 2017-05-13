class SideStudentController {
	constructor() {
		'ngInject'

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
}

export default {
	template: require('./side-student.html'),
	controller: SideStudentController
};