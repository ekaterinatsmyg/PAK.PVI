import Test from './Test';

class Experiment {
    constructor ({name = '', tests = []}) {
        this.name = name;
        this.tests = tests.map(test => new Test(test));
    }
}

export default Experiment;


