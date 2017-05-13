class MainController {
	constructor($state) {
		'ngInject'

        this.$state = $state;
	}

    toState(state) {
        if (!state) return;

        this.$state.go(state);
    }

}

export default {
	template: require('./index.html'),
	controller: MainController
};