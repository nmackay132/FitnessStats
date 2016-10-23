define(["Models/Run"], function (Run) {
    var ViewModel = function() {
        var self = this;

        self.runsList = [];

        $.ajax({
            type: 'GET',
            url: 'api/Runkeeper/GetRuns',
            data: {
                format: 'json'
            },
            success: function (response) {
                displayRuns(response.Data);
            }
        });

        var displayRuns = function (rawRuns) {
            convertToRuns(rawRuns);

            $('#RunkeeperStats table').DataTable({
                data: self.runsList,
                columns: [
                    { title: "#" },
                    { title: "Start Time" },
                    { title: "Duration" },
                    { title: "Distance (miles)" },
                    { title: "Pace" },
                    { title: "Calories" }
                ]
            }
            );
        }

        var convertToRuns = function (rawRuns) {
            var runCount = rawRuns.length;

            for (var i = 0; i < runCount; i++) {
                var run = rawRuns[i];
                self.runsList.push(new Run(runCount - i, run.Duration, run.StartTime, run.TotalCalories, run.TotalDistance).toStringArray());
            }
        }
    }

    return ViewModel;

});

