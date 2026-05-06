using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamJob
{
    [JsiiInterface(nativeType: typeof(IAiVisionStreamJobFeaturesTrackingTypes), fullyQualifiedName: "oci.aiVisionStreamJob.AiVisionStreamJobFeaturesTrackingTypes")]
    public interface IAiVisionStreamJobFeaturesTrackingTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#biometric_store_compartment_id AiVisionStreamJob#biometric_store_compartment_id}.</summary>
        [JsiiProperty(name: "biometricStoreCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BiometricStoreCompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#biometric_store_id AiVisionStreamJob#biometric_store_id}.</summary>
        [JsiiProperty(name: "biometricStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BiometricStoreId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#detection_model_id AiVisionStreamJob#detection_model_id}.</summary>
        [JsiiProperty(name: "detectionModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DetectionModelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#max_results AiVisionStreamJob#max_results}.</summary>
        [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxResults
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#objects AiVisionStreamJob#objects}.</summary>
        [JsiiProperty(name: "objects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Objects
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#should_return_landmarks AiVisionStreamJob#should_return_landmarks}.</summary>
        [JsiiProperty(name: "shouldReturnLandmarks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldReturnLandmarks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#tracking_model_id AiVisionStreamJob#tracking_model_id}.</summary>
        [JsiiProperty(name: "trackingModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrackingModelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiVisionStreamJobFeaturesTrackingTypes), fullyQualifiedName: "oci.aiVisionStreamJob.AiVisionStreamJobFeaturesTrackingTypes")]
        internal sealed class _Proxy : DeputyBase, oci.AiVisionStreamJob.IAiVisionStreamJobFeaturesTrackingTypes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#biometric_store_compartment_id AiVisionStreamJob#biometric_store_compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "biometricStoreCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BiometricStoreCompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#biometric_store_id AiVisionStreamJob#biometric_store_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "biometricStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BiometricStoreId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#detection_model_id AiVisionStreamJob#detection_model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "detectionModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DetectionModelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#max_results AiVisionStreamJob#max_results}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxResults
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#objects AiVisionStreamJob#objects}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Objects
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#should_return_landmarks AiVisionStreamJob#should_return_landmarks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldReturnLandmarks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldReturnLandmarks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#tracking_model_id AiVisionStreamJob#tracking_model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trackingModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrackingModelId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
