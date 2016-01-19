namespace CraigslistExample.Controllers {

    export class listOfListingsController {
        
        public listings;

        constructor(private $http) {
            $http.get('/api/listings')
                .then((response) => {
                    this.listings = response.data;
                })
        }
    }
}