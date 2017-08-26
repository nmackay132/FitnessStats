//TODO: Complete, unsure of how to use $.Deffered().
define([], function() {
    var Ajax = function() {
        var self = this;

        self.jsonRequest = function(url, data, method) {

            var deferred = $.Deferred();

            var options = {
                data: data,
                type: method || 'POST'
            };

            $.ajax(url, options)
                .done(function(data) {
                    deferred.resolve(data);
                })
                .fail(function(data) {
                    deferred.reject(data);
                });

            return deferred.promise();
        };

        self.getJSON = function(url, data) {
            return self.jsonRequest(url, data, 'GET');
        };

        self.postJSON = function(url, data) {
            return self.jsonRequest(url, data, 'POST');
        };
    };

    return new Ajax();
});