var CraigslistExample;
(function (CraigslistExample) {
    var Controllers;
    (function (Controllers) {
        var listOfListingsController = (function () {
            function listOfListingsController($http) {
                var _this = this;
                this.$http = $http;
                $http.get('/api/listings')
                    .then(function (response) {
                    _this.listings = response.data;
                });
            }
            return listOfListingsController;
        })();
        Controllers.listOfListingsController = listOfListingsController;
    })(Controllers = CraigslistExample.Controllers || (CraigslistExample.Controllers = {}));
})(CraigslistExample || (CraigslistExample = {}));
//# sourceMappingURL=listOfListingsController.js.map