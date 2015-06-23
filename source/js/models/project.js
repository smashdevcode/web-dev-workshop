
var Project = function (projectData) {
    var self = this;

    self.projectId = 0;
    self.name = '';
    self.description = '';
    self.tasks = [];

    if (projectData) {
        setData(projectData);
    }

    self.hasTasks = function () {
        return self.tasks.length > 0;
    };

    self.percentComplete = function () {
        return getPercentComplete(self.tasks);
    };

    self.totalHours = function () {
        return getTotalHours(self.tasks).toFixed(1);
    };

    self.totalCompletedHours = function () {
        return getTotalCompletedHours(self.tasks).toFixed(1);
    };

    self.totalRemainingHours = function () {
        return getTotalRemainingHours(self.tasks).toFixed(1);
    };

    self.addTask = function () {
        var task = new ProjectTask();

        self.tasks.push(task);
    };

    self.deleteTask = function (task) {
        self.tasks.remove(task);
    };

    self.getData = function () {
        return {
            projectId: self.projectId,
            name: self.name,
            description: self.description,
            tasks: self.tasks.map(function (task) {
                return {
                    name: task.name,
                    completed: task.completed,
                    hours: task.hours
                };
            })
        }
    };

    self.setData = function (projectData) {
        setData(projectData);
    };

    // private functions

    function getPercentComplete(tasks) {
        var totalHours = getTotalHours(tasks),
            completedHours = getTotalCompletedHours(tasks);

        if (totalHours > 0) {
            return ((completedHours / totalHours) * 100).toFixed(0) + '%';
        } else {
            return 'N/A';
        }
    }

    function getTotalHours(tasks) {
        return _.sum(tasks, function (task) {
            return task.hours;
        });
    }

    function getTotalCompletedHours(tasks) {
        return _.sum(tasks, function (task) {
            return task.completed ? task.hours : 0;
        });
    }

    function getTotalRemainingHours(tasks) {
        var totalHours = getTotalHours(tasks),
            completedHours = getTotalCompletedHours(tasks);

        return totalHours - completedHours;
    }

    function setData(projectData) {
        self.projectId = projectData.projectId;
        self.name = projectData.name;
        self.description = projectData.description;

        self.tasks = projectData.tasks.map(function (taskData) {
            return new ProjectTask(taskData);
        });
    }
};
