import User from './../models/User';
import {userConstants, pagesConstants} from '../../constants';

class UserManager {
    constructor($log, api, $q, $http, $filter, $location, localStorage, CacheFactory) {
        'ngInject';

        this.cache = CacheFactory.get('User') || new CacheFactory('User');
        this.$log = $log;
        this.api = api;
        this.$q = $q;
        this.$http = $http;
        this.$filter = $filter;
        this.$location = $location;
        this.localStorage = localStorage;
    }

    getRoles() {
        return this.api.role.query();
    }

    ///////SELECT & EDIT/////////

    query({fio, role, limit, offset} = {}) {
        return this.api
            .user
            .query({fio, role, limit, offset})
            .then(([users, headers]) => [users, headers['x-total-count']]);
    }

    getById(id) {
        return this.api.user.get({id: id});
    }

    save(user) {
        return (user.id) ? this.api.user.patch(user) : this.api.user.save(user);
    }

    ///////AUTH & REGISTRATION/////////

    loadUserCredentials() {
        return new Promise((resolve, reject) => {
            let user = this.cache.get(userConstants.CURRENT_KEY);
            let token = this.cache.get(userConstants.AUTH_USER_HEADER_KEY);

            if (!user || !token) {
                return reject();
            }

            this.useCredentials(token);

            return this.current();
        });
    }

    storeUserCredentials(token, user) {
        this.cache.put(userConstants.AUTH_USER_HEADER_KEY, token);
        this.cache.put(userConstants.CURRENT_KEY, user);
        this.useCredentials(token);
    }

    useCredentials(token) {
        this.$http.defaults.headers.common[userConstants.AUTH_HEADER_KEY] = token;
    }

    destroyUserCredentials() {
        this.$http.defaults.headers.common[userConstants.AUTH_HEADER_KEY] = undefined;
        this.cache.remove(userConstants.AUTH_USER_HEADER_KEY);
        this.cache.remove(userConstants.CURRENT_KEY);
    }

    current() {
        return new Promise((resolve, reject) => {
            let user = (new User(this.cache.get(userConstants.CURRENT_KEY)));

            if (!user.id) {
                return reject();
            }

            console.log(user);
            return resolve(user);
        })
    }

    login(email, password, username = email) {
        return this.api.session.login({email, username, password})
            .then((userSession) => {
                this.storeUserCredentials(userSession[userConstants.AUTH_USER_HEADER_KEY], userSession.user);
                return this.$filter('translate')('AUTH SUCCESS');
            });
    }

    loginByToken(token) {
        return this.api.session.loginByToken({token})
            .then((userSession) => {
                this.storeUserCredentials(userSession[userConstants.AUTH_USER_HEADER_KEY], userSession.user);
                return this.$filter('translate')('AUTH SUCCESS');
            });
    }

    registration(email, password, username = email) {
        return this.api.users.save({email, username, password})
            .then(() => this.$filter('translate')('REGISTRATION SUCCESS'));
    }

    logout() {
        this.destroyUserCredentials();
        this.localStorage.clear();
        this.$location.path(pagesConstants.LOGIN);
    }

    restorePass(email, isAdminForm = false) {
        return this.api.userPass.restore({email, is_admin_form: isAdminForm})
            .then(() => this.$filter('translate')('RESTORE PASS SUCCESS'));
    }

    /////// REPORTS AND STAT /////////
    loadReport(data = {}) {
        return (data.destination === 'csv') ?
            this.api.userReport.queryCsv(data) :
            this.api.userReport.query(data);
    }

    loadStatistic(countCohort) {
        return this.api.userStat.query({ count_cohort: countCohort });
    }
}

export default UserManager;