const gulp = require('gulp');
const concat = require('gulp-concat');
const cssmin = require('gulp-cssmin');
const uglify = require('gulp-uglify');

gulp.task('minify-js', () => {
    return gulp.src('wwwroot/js/**/*.js')
        .pipe(concat('tablerForNet.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js'));
});

gulp.task('minify-css', () => {
    return gulp.src('wwwroot/css/**/*.css')
        .pipe(concat('tablerForNet.min.css'))
        .pipe(cssmin())
        .pipe(gulp.dest('wwwroot/css'));
});

// Beobachtet Änderungen in JS und CSS Dateien
gulp.task('watch', () => {
    gulp.watch('wwwroot/js/**/*.js', gulp.series('minify-js'));
    gulp.watch('wwwroot/css/**/*.css', gulp.series('minify-css'));
});

// Standardtask, der Minimierungsaufgaben und Watcher startet
gulp.task('default', gulp.series(['minify-js', 'minify-css', 'watch']));
