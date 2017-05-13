import User from './models/User';

function config(apiProvider, API_URL) {
    'ngInject';

    apiProvider.setBaseRoute(API_URL);

    apiProvider.endpoint('user')
        .route('users/:id')
        .model(User)
        .addHttpAction('GET', 'query', {isArray: true, headersForReading: ['x-total-count']})
        .addHttpAction('PATCH', 'patch', {params: {id: '@id'}})
    ;
}

export default config;