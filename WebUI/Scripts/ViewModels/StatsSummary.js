define(["utils/ajax-utils"], function (ajax) {
    var vm = function () {
        var self = this;
        self.totalMiles = ko.observable();
        self.totalCalories = ko.observable();
        self.totalDuration = ko.observable();

        self.initialize = function (options) {
            getStats(options.getStatsUrl);
        }

        function getStats(url) {
            ajax.getJSON(url)
                .done(function (response) {
                    displayStats(response.Data);
                });
        }

        function displayStats(data) {
            self.totalMiles(data.TotalMilesFormatted);
            self.totalCalories(data.TotalCaloriesFormatted);
            self.totalDuration(data.TotalDurationFormatted);
        }
    }

    return vm;

});

