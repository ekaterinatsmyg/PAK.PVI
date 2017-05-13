class UserReport {
    constructor({id, ip, email, fio, roles, created_at, first_auth_date, last_auth_date, last_activity_date, average_online,
                average_auth} = {}) {
        this.id = id;
        this.email = email || '';
        this.fio = fio || '';
        this.roles = (roles) ? roles.join() : '';
        this.created_at = created_at || '';
        this.last_auth_date = last_auth_date || '';
        this.last_activity_date = last_activity_date || '';
    }

    getFields() {
        return  [
            {filterShow: true, field: 'email', name: 'email', type: 'string'},
            {filterShow: false, field: 'fio', name: 'ФИО', type: 'string'}, // для фильтрации по фио необходимо дорабатывать бэкенд, т.к. поля fio нет в БД
            {filterShow: true, field: 'roles', name: 'Статус/Роль', type: 'string'},
            {filterShow: true, field: 'created_at', name: 'Дата регистрации/заведения пользователя', type: 'date', default: new Date()},
            {filterShow: true, field: 'last_auth_date', name: 'Дата последней авторизации', type: 'date', default: new Date()},
            {filterShow: true, field: 'last_activity_date', name: 'Дата последней активности', type: 'date', default: new Date()},

        ];
    }

    getFilters() {
        return {
            string: [
                {type: 'equal', name: 'Равно'},
                {type: 'not_equal', name: 'Не равно'},
                {type: 'like', name: 'Содержит'},
                {type: 'not_like', name: 'Не содержит'},
                {type: 'is_not_null', name: 'Содержит данные'},
                {type: 'is_null', name: 'Не содержит данные'},
            ],
            integer: [
                {type: 'equal', name: 'Равно'},
                {type: 'not_equal', name: 'Не равно'},
                {type: 'more', name: 'Больше'},
                {type: 'less', name: 'Меньше'}
            ],
            date: [
                {type: 'start_date', name: 'C'},
                {type: 'end_date', name: 'По'}
            ],
            boolean: [
                {type: 'boolean', name: 'Истина', data: true},
                {type: 'boolean', name: 'Ложь', data: false}
            ],
            time: [
                {type: 'start_time', name: 'От'},
                {type: 'end_time', name: 'До'},
            ]
        };
    }

    getDestinations() {
        return [
            {type: 'screen', name: 'На экран'}
        ];
    }

}

export default UserReport;