# ASP.netRateLimit
Rate Limit of Requests in Global.asax by client



The rate limiting code provided in the this examples will work for multiple client applications as long as the requests are made to the same server and the rate limiting is implemented on the server side.

However, if the client applications are making requests to different servers, the rate limiting will need to be implemented on each server independently. In this case, you will need to use a different approach to rate limiting that is specific to the server architecture and infrastructure.

For example, if you are using a load balancer to distribute requests across multiple servers, you can use the load balancer's rate limiting features to limit the number of requests that each server receives. Alternatively, you can use a service like CloudFlare or AWS WAF to rate limit requests at the edge of the network.

It's also important to note that the rate limiting code provided in the previous examples is just one way to implement rate limiting and is intended as a starting point. Depending on your specific requirements and constraints, you may need to modify the code or use a different approach to rate limiting.
