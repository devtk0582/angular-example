var myApp = angular.module("myApp", [])

var homeController = myApp.controller("HomeController", ["$scope", function ($scope) {
    $scope.title = "Home Title";
    $scope.header = "Directory";
    $scope.links = [
        {
            "name": "Countries",
            "link": "Find A Country",
            "url": "country"
        },
        {
            "name": "US States",
            "link": "Find A State",
            "url": "state"
        },
        {
            "name": "US Cities",
            "link": "Find A City",
            "url": "city"
        },
        {
            "name": "US Zip Codes",
            "link": "Find A Zip Code",
            "url": "zipcode"
        }
    ]
}]);

var countryController = myApp.controller("CountryController", ["$scope", "$http", function ($scope, $http) {
    $scope.title = "Find A Country";
    $scope.header = "Country List";
    $http.get("country/getcountries").then(function (response) {
        $scope.countries = response.data;
    }, function (response) {
        alert(response.statusText);
    });
}]);
