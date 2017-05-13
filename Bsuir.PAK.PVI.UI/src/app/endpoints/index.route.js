function routeConfig($stateProvider) {
	'ngInject';

	$stateProvider
		.state('main', {
			url: '/',
			template: '<pak-main></pak-main>'
		});
}

export default routeConfig;