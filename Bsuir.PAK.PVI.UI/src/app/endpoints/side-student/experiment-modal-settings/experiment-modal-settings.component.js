class ExperimentModalSettingsController {
    constructor() {
        'ngInject';

        this.time = null;

        this.timeSettings = {
            hstep: 1,
            mstep: 1
        };
    }

    ok() {
        this.modalInstance.close(this.time);
    }

    close() {
        this.modalInstance.dismiss('cancel');
    }
}

export default {
    template: require('./experiment-modal-settings.html'),
    controller: ExperimentModalSettingsController,
    bindings: {
        modalInstance: '<'
    }
};
