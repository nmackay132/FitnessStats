define(["Models/Run", "utils/ajax-utils"], function (Run, ajax) {
    var ViewModel = function() {
        var self = this;
        self.runsList = [];

        self.initialize = function(options) {
            getRunsData(options.getRunsUrl);
        }

        function getRunsData(url) {
            ajax.getJSON(url)
                .done(function(response) {
                    displayRuns(response.Data);
                });
        }

        function displayRuns(rawRuns) {
            convertToRuns(rawRuns);

            $('#RunkeeperStats table').DataTable({
                data: self.runsList,
                order: [[ 0, "desc" ]],
                columns: [
                    { title: "Start Time" },
                    { title: "Duration" },
                    { title: "Distance (miles)" },
                    { title: "Pace" },
                    { title: "Calories" }
                ]
            });
        }

        function convertToRuns(rawRuns) {
            var runCount = rawRuns.length;

            for (var i = 0; i < runCount; i++) {
                var run = rawRuns[i];
                self.runsList.push(new Run(run.duration, run.start_time, run.total_calories, run.total_distance).toStringArray());
            }
        }
    }

    return ViewModel;

});

