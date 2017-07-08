(function (app) {
    app.filter('homeflagFilter', function () {
        return function (input) {
            if (input == true)
                return 'Có';
            else
                return 'Không';
        }
    })
})(angular.module('sms.common'));