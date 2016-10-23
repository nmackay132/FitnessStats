//TODO: Complete, unsure of how to use $.Deffered().
define([], function() {
    var Ajax = function() {
        var self = this;

        self.jsonRequest = function(url, data, method, async) {

            var deferred = $.Deferred();

            var options = {
                data: data,
                type: method || 'POST'
            };

            if (undefined != async) {
                options.async = async;
            }

            var request =
                $.ajax(url, options).DONE(function(data) {

                });
        }
    }
});