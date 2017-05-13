const gutil = require('gulp-util');
const isAdminSide = (gutil.env.side == 'admin');

exports.isAdminSide = isAdminSide;
exports.isBuildMode = false;

exports.paths = {
    initModule: '/app/index.module.js',
    src: 'src',
    app: 'src/app',
    dist: '../web',
    base_href: '/',
    vendor_html: 'src/app/index.html',
    tmp: '.tmp'
};

/**
 * Папки/файлы которые перезаписываются при билде и добавляются в гит
 */
exports.cleanDist = [
    exports.paths.dist + '/index.html',
    exports.paths.dist + '/assets',
    exports.paths.dist + '/styles',
    exports.paths.dist + '/scripts',
    exports.paths.dist + '/fonts'
];

/**
 *  Wiredep is the lib which inject bower dependencies in your project
 *  Mainly used to inject script tags in the index.html but also used
 *  to inject css preprocessor deps and js files in karma
 */
exports.wiredep = {
    exclude: [/bootstrap.js$/, /bootstrap-sass-official\/.*\.js/, /bootstrap\.css/],
    directory: 'bower_components'
};

/**
 *  Common implementation for an error handler of a Gulp plugin
 */
exports.errorHandler = function (title) {
    'use strict';

    return function (err) {
        gutil.log(gutil.colors.red('[' + title + ']'), err.toString());
        this.emit('end');
    };
};
