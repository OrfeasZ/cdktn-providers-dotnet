using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiVisionStreamJob.AiVisionStreamJobFeatures")]
    public class AiVisionStreamJobFeatures : oci.AiVisionStreamJob.IAiVisionStreamJobFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#feature_type AiVisionStreamJob#feature_type}.</summary>
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}")]
        public string FeatureType
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

        private object? _trackingTypes;

        /// <summary>tracking_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#tracking_types AiVisionStreamJob#tracking_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trackingTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiVisionStreamJob.AiVisionStreamJobFeaturesTrackingTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrackingTypes
        {
            get => _trackingTypes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AiVisionStreamJob.IAiVisionStreamJobFeaturesTrackingTypes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiVisionStreamJob.IAiVisionStreamJobFeaturesTrackingTypes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trackingTypes = value;
            }
        }
    }
}
