var requirejs = require('requirejs');

requirejs.config({
    //Pass the top-level main.js/index.js require
    //function to requirejs so that node modules
    //are loaded relative to the top-level JS file.
    nodeRequire: require
});

if (typeof define !== 'function') {
    var define = require('amdefine')(module);
}

define(function (require) {
    var dep = require('dependency');

    //The value returned from the function is
    //used as the module export visible to Node.
    return function () { };
});