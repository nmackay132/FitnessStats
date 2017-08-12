var gulp  = require('gulp'),
	less = require('gulp-less'),
    gutil = require('gulp-util');

// create a default task and just log a message
gulp.task('default', function() {
  return gutil.log('Gulp is running!')
});

// compile less into css
gulp.task('build-less', function() {
	return gulp.src('WebUI/Content/less/**/*.less')
	.pipe(less())
	.pipe(gulp.dest('WebUI/Content/css'));
});

