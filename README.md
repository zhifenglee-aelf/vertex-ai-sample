# Vertex AI Prediction Client in .NET

This project demonstrates how to connect to a deployed Vertex AI model on Google Cloud using the `Google.Cloud.AIPlatform.V1` NuGet package with a dedicated endpoint. The sample application authenticates using Application Default Credentials (ADC) and performs a prediction request.

## Prerequisites

- **.NET SDK:** .NET 6.0 or later.
- **Google Cloud Project:** A project with Vertex AI enabled.
- **Service Account Credentials:** A service account JSON key file with the necessary permissions.
- **Deployed Vertex AI Model:** A model deployed to an endpoint with a dedicated endpoint domain.
- **Google Cloud SDK (optional):** For setting up ADC using:
  ```bash
  gcloud auth application-default login
  ```
- **Service Account Key** For setting up service account key, please check GCP documentation and use the following:
  ```bash
  export GOOGLE_APPLICATION_CREDENTIALS="/absolute/path/to/your/service-account-key.json"
  ```
