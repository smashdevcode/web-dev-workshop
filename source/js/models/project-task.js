
var ProjectTask = function (projectTaskData) {
    var self = this;

    self.name = '';
    self.completed = false;
    self.hours = 0;

    if (projectTaskData) {
        self.name = projectTaskData.name;
        self.completed = projectTaskData.completed;
        self.hours = projectTaskData.hours;
    }
};
