class AlertResponse {
    constructor(alert) {
        'ngInject';

        this.alert = alert;
    }

    success (response) {
        this.alert({type: 'success', title: 'Успешно'});
    }

    fail (response) {
        let message = 'Неопознанная ошибка';

        if (response.data && response.data.message) {
            message = response.data.message;
        } else if (response.data) {
            if (response.data.error) {
                message = `${response.data.error.message} (${response.data.error.code})`;
            } else if (response.data.data === null) {

            } else {
                let errors = [];
                Object.keys(response.data).forEach((key) => errors.push(`<li>${response.data[key]}</li>`));
                message = `<ul>${errors.join("\n")}</ul>`;
            }
        }

        this.alert({type: 'error', title: 'Ошибка!', text: message, html: true});
    }
}

export default AlertResponse;