﻿namespace ZomatoApiCall
{
    public static class ZomatoInfo
    {
        const string url = "https://developers.zomato.com/api/v2.1/";
        const string apiKey = "749b7981ff9e98b3b0ed487c17028e6e";

        public static RestaurantList GetRestaurants()
        {
            string urlParameters = $"search?entity_id=59&entity_type=city&apikey={apiKey}";
            var response = APICall.RunAsync<RestaurantList>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }

        public static ReviewList GetReviews(int restaurantID)
        {
            string urlParameters = $"reviews?res_id={restaurantID}&apikey={apiKey}";
            var response = APICall.RunAsync<ReviewList>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }
}
