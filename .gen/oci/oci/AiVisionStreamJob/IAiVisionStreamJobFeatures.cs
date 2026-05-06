using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamJob
{
    [JsiiInterface(nativeType: typeof(IAiVisionStreamJobFeatures), fullyQualifiedName: "oci.aiVisionStreamJob.AiVisionStreamJobFeatures")]
    public interface IAiVisionStreamJobFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#feature_type AiVisionStreamJob#feature_type}.</summary>
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}")]
        string FeatureType
        {
            get;
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

        /// <summary>tracking_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#tracking_types AiVisionStreamJob#tracking_types}
        /// </remarks>
        [JsiiProperty(name: "trackingTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiVisionStreamJob.AiVisionStreamJobFeaturesTrackingTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrackingTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiVisionStreamJobFeatures), fullyQualifiedName: "oci.aiVisionStreamJob.AiVisionStreamJobFeatures")]
        internal sealed class _Proxy : DeputyBase, oci.AiVisionStreamJob.IAiVisionStreamJobFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#feature_type AiVisionStreamJob#feature_type}.</summary>
            [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}")]
            public string FeatureType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#max_results AiVisionStreamJob#max_results}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxResults
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#should_return_landmarks AiVisionStreamJob#should_return_landmarks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldReturnLandmarks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldReturnLandmarks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tracking_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#tracking_types AiVisionStreamJob#tracking_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trackingTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiVisionStreamJob.AiVisionStreamJobFeaturesTrackingTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrackingTypes
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
