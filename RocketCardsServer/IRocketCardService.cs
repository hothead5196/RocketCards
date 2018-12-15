using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RocketCardsServer
{
    [ServiceContract]
    public interface IRocketCardService
    {
        [WebGet(UriTemplate = "/api")]
        Stream API();

        // Receive Trade publish     POST

        // Give Trade List      GET

        // Receive Trade Accept   PUT

        // Push users card list     GET

        // Push leaderboard list    GET

        // Receive daily reward request     GET

        // Send daily reward notification   GET

        // Register Username and password:  POST

        // Login With Username and password:    PUT

        // logout   PUT
    }
}