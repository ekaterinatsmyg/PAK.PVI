function routeConfig($stateProvider) {
	'ngInject';

	$stateProvider
		.state('student', {
			url: '/student',
			template: '<side-student></side-student>'
		});
}

export default routeConfig;