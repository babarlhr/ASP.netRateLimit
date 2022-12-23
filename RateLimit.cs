public class RateLimit
{
    // Static variables to keep track of the number of requests made by the client
    private static int requestCount = 0;
    private static DateTime lastRequestTime = DateTime.MinValue;

    // Method to check if the request count exceeds the rate limit
    public static bool CheckRateLimit()
    {
        // Calculate the time elapsed since the last request
        TimeSpan elapsedTime = DateTime.Now - lastRequestTime;

        // If the time elapsed is greater than 10 seconds, reset the request count
        if (elapsedTime.TotalSeconds > 10)
        {
            requestCount = 0;
        }

        // Increment the request count
        requestCount++;

        // Check if the request count exceeds the rate limit
        if (requestCount > 10)
        {
            return false;
        }
        else
        {
            // Update the last request time
            lastRequestTime = DateTime.Now;
            return true;
        }
    }
}
