function routeConfig($stateProvider) {
	'ngInject';

	$stateProvider
		.state('admin', {
			url: '/admin',
			template: '<side-admin></side-admin>'
		});
}

export default routeConfig;