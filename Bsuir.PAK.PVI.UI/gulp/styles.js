'use strict';

const path = require('path');
const gulp = require('gulp');
const conf = require('./conf');
const browserSync = require('browser-sync');
const $ = require('gulp-load-plugins')();
const wiredep = require('wiredep').stream;
const _ = require('lodash');

gulp.task('styles', function () {
  let sassOptions = {
    style: 'expanded'
  };

  let exceptPath = conf.isAdminSide ? '/app/side-client' : '/app/side-admin';
  let injectFiles = gulp.src([
    path.join(conf.paths.src, '/**/*.scss'),
    path.join('!' +conf.paths.src, exceptPath + '/**/*.scss'),
    path.join('!' + conf.paths.src, '/app/index.scss')
  ], { read: false });

  let injectOptions = {
    transform: function(filePath) {
      filePath = filePath.replace(conf.paths.src + '/app/', '');
      return '@import "' + filePath + '";';
    },
    starttag: '// injector',
    endtag: '// endinjector',
    addRootSlash: false
  };


  return gulp.src([
    path.join(conf.paths.src, '/app/index.scss')
  ])
    .pipe($.inject(injectFiles, injectOptions))
    .pipe(wiredep(_.extend({}, conf.wiredep)))
    .pipe($.sourcemaps.init())
    .pipe($.sass(sassOptions)).on('error', conf.errorHandler('Sass'))
    .pipe($.autoprefixer()).on('error', conf.errorHandler('Autoprefixer'))
    .pipe($.sourcemaps.write())
    .pipe(gulp.dest(path.join(conf.paths.tmp, '/serve/app/')))
    .pipe(browserSync.reload({ stream: true }));
});
