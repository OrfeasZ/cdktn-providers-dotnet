using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamJob
{
    [JsiiByValue(fqn: "oci.aiVisionStreamJob.AiVisionStreamJobFeaturesTrackingTypes")]
    public class AiVisionStreamJobFeaturesTrackingTypes : oci.AiVisionStreamJob.IAiVisionStreamJobFeaturesTrackingTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#biometric_store_compartment_id AiVisionStreamJob#biometric_store_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "biometricStoreCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BiometricStoreCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#biometric_store_id AiVisionStreamJob#biometric_store_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "biometricStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BiometricStoreId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#detection_model_id AiVisionStreamJob#detection_model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "detectionModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DetectionModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#max_results AiVisionStreamJob#max_results}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxResults
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#objects AiVisionStreamJob#objects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Objects
        {
            get;
            set;
        }

        private object? _shouldReturnLandmarks;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#should_return_landmarks AiVisionStreamJob#should_return_landmarks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldReturnLandmarks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldReturnLandmarks
        {
            get => _shouldReturnLandmarks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldReturnLandmarks = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#tracking_model_id AiVisionStreamJob#tracking_model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trackingModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrackingModelId
        {
            get;
            set;
        }
    }
}
