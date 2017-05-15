class ExecuteTestController {
    constructor($scope, $timeout) {
        'ngInject';

        this.$scope = $scope;
        this.$timeout = $timeout;
        this.timeDelay = this.timeDelay || 3000;
        this.iterationDelay = 1000;
        this.results = [[],[],[]];

        this.input = null;
        this.currentStymulId = 0;
        this.currentIteration = 0;

        this.maxIteration = 4;

        this.isShowStymul = false;
        this.isShowInput = false;
        this.isShowMultiply = false;
        this.isShowFake = false;

        this._registerWatchers();
    }

    applyResult() {
        console.log(this)
        this.isShowInput = false;
        this.isShowStymul = false;
        this.isShowMultiply = false;
        this.isShowFake = false;

        if (this.currentStymulId >= this.test.stymulus.length - 1) {
            return this.onFinishTest({results: this.results});
        }

        if (this.currentIteration !== 0) {
            this.results[this.currentStymulId].push(this.input);
        }
        this.input = null;

        if (this.currentIteration === this.maxIteration) {
            this.currentIteration = 0;
            this.currentStymulId++;
        }

        if (this.currentIteration === 0) {
            this.isShowStymul = true;
            this.$timeout(() => {
                this.isShowStymul = false;
                this.isShowInput = true;
                this.currentIteration++;
            }, this.timeDelay);
        }

        if (this.currentIteration === 1) {
            this.isShowStymul = true;
            this.$timeout(() => {
                this.isShowStymul = false;
                    this.$timeout(() => {
                        this.isShowInput = true;
                        this.currentIteration++;
                    }, this.iterationDelay);
                }, this.timeDelay);
        }

        if (this.currentIteration === 2) {
            this.isShowStymul = true;
            this.$timeout(() => {
                this.isShowStymul = false;
                this.showMultiply();
            }, this.timeDelay);
        }

        if (this.currentIteration === 3) {
            this.isShowStymul = true;
            this.$timeout(() => {
                this.isShowStymul = false;
                this.isShowFake = true;
                this.$timeout(() => {
                    this.isShowFake = false;
                    this.currentIteration++;
                    this.isShowInput = true;
                }, this.timeDelay);
            }, this.timeDelay);
        }

        console.log(this.results)
    }

    showMultiply() {
        this.multiplyNumberFirst = Math.floor(Math.random() * (99 - 10)) + 10;
        this.multiplyNumberSecond = Math.floor(Math.random() * (99 - 10)) + 10;
        this.isShowMultiply = true;
    }

    confirmMultipy() {
        this.multiplyError = null;
        console.log(this.multiplyNumberFirst * this.multiplyNumberSecond, this.multiplyResult)
        if (this.multiplyNumberFirst * this.multiplyNumberSecond != this.multiplyResult) {

            this.multiplyError = 'Неверный результат';
            this.multiplyResult = null;
        } else {
            this.isShowMultiply = false;
            this.isShowInput = true;
            this.currentIteration++;
        }
    }

    _registerWatchers() {
        this.$scope.$watch(() => this.test, (newTest) => {
            if (newTest) {
                this.applyResult();
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