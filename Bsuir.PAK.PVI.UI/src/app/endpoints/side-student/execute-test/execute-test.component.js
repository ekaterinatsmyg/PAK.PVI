class ExecuteTestController {
    constructor($scope, $timeout) {
        'ngInject';

        this.$scope = $scope;
        this.$timeout = $timeout;
        this.timeDelay = this.timeDelay || 3000;
        this.results = [];

        this.input = null;
        this.currentStymulId = 0;

        this.maxIteration = 4;

        this._registerWatchers();
    }

    runTest() {
        this.isShow = true;
        this.$timeout(() => {
            this.isShow = false;
        }, this.timeDelay);
    }

    applyResult() {
        if (this.currentStymulId >= this.maxIteration) {
            return this.onFinishTest({results: this.results});
        }

        this.results.push(this.input);
        this.input = null;
        this.currentStymulId++;
        this.runTest();
    }

    _registerWatchers() {
        this.$scope.$watch(() => this.test, (newTest) => {
            if (newTest) {
                this.runTest();
            }
        });
    }
}

export default {
    template: require('./execute-test.html'),
    controller: ExecuteTestController,
    bindings: {
        test: '<',
        timeDelay: '<?',

        onFinishTest: '&'
    }
};