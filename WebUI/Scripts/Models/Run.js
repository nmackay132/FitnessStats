define([], function () {
    var Run = function(duration, startTime, totalCalories, totalDistance) {
        var self = this;
        var KM_TO_MILES = 0.621371;
        var MILES_TO_KM = 1.60934;
        var startTime = new Date(startTime);

        var kms = totalDistance / 1000.0;
        var miles = kms * KM_TO_MILES;
        var durationFormatted = formatDuration(duration);
        var paceFormatted = formatPace(duration, miles);

        self.duration = ko.observable(durationFormatted);
        self.kilometers = ko.observable(parseFloat(kms).toFixed(2));
        self.miles = ko.observable(parseFloat(miles).toFixed(2));
        self.startTime = ko.observable(startTime.toDateString());
        self.pace = ko.observable(paceFormatted);
        self.calories = ko.observable(Math.round(totalCalories));

        function formatPace(duration, distance) {
            var paceInTotalSeconds = duration / distance;
            var paceInMinutes = Math.floor(paceInTotalSeconds / 60);
            var paceExtraSeconds = Math.round(paceInTotalSeconds - paceInMinutes * 60);
            return paceInMinutes + "m:" + paceExtraSeconds + "s";
        }

        function formatDuration(duration) {
            var hours = Math.floor(duration / (60 * 60));
            var minutes = Math.floor((duration - (60 * 60 * hours)) / 60);
            var seconds = Math.round((duration - (60 * 60 * hours + 60 * minutes)));
            var hStr = "";
            if (hours > 0) hStr = hours + "h:";
            return hStr + minutes + "m:" + seconds + "s";
        }

        self.toStringArray = function () {
            return [self.startTime, self.duration, self.miles, self.pace, self.calories];
        }
    }

    return Run;
});