using Google.Cloud.AIPlatform.V1;
using Google.Protobuf.WellKnownTypes;
using Value = Google.Protobuf.WellKnownTypes.Value;

namespace vertex_ai_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace these with your actual GCP details.
            var projectId = "179791531555";
            var location = "us-central1"; // e.g., "us-central1"
            var endpointId = "60311511318396928";

            // Dedicated endpoint provided in the error message.
            //var dedicatedEndpoint = "60311511318396928.us-central1-fasttryout.prediction.vertexai.goog";
            var dedicatedEndpoint = $"https://60311511318396928.us-central1-fasttryout.prediction.vertexai.goog/v1/projects/{projectId}/locations/{location}/endpoints/{endpointId}:predict";
            
            // Create a client builder with the dedicated endpoint.
            var builder = new PredictionServiceClientBuilder
            {
                Endpoint = dedicatedEndpoint
            };
            var predictionClient = builder.Build();

            // Construct the full resource name of the endpoint.
            var endpoint = new EndpointName(projectId, location, endpointId);

            // Prepare your instance(s) for prediction.
            // In this example, we assume the deployed model expects simple string input.
            var instances = new List<Value>
            {
                Value.ForString("sample input text")
            };

            // Optional: Define prediction parameters if required by your model.
            var parameters = Value.ForStruct(new Struct());

            // Call the Predict method.
            //var response = predictionClient.Predict(endpoint, instances, parameters);
            var response = predictionClient.Predict(dedicatedEndpoint, instances, parameters);

            // Output the predictions returned by the deployed model.
            Console.WriteLine("Predictions:");
            foreach (var prediction in response.Predictions)
            {
                Console.WriteLine(prediction);
            }
        }
    }
}