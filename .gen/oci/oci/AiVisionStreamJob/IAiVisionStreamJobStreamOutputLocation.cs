using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamJob
{
    [JsiiInterface(nativeType: typeof(IAiVisionStreamJobStreamOutputLocation), fullyQualifiedName: "oci.aiVisionStreamJob.AiVisionStreamJobStreamOutputLocation")]
    public interface IAiVisionStreamJobStreamOutputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#bucket AiVisionStreamJob#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#namespace AiVisionStreamJob#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#output_location_type AiVisionStreamJob#output_location_type}.</summary>
        [JsiiProperty(name: "outputLocationType", typeJson: "{\"primitive\":\"string\"}")]
        string OutputLocationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#prefix AiVisionStreamJob#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#obo_token AiVisionStreamJob#obo_token}.</summary>
        [JsiiProperty(name: "oboToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OboToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiVisionStreamJobStreamOutputLocation), fullyQualifiedName: "oci.aiVisionStreamJob.AiVisionStreamJobStreamOutputLocation")]
        internal sealed class _Proxy : DeputyBase, oci.AiVisionStreamJob.IAiVisionStreamJobStreamOutputLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#bucket AiVisionStreamJob#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#namespace AiVisionStreamJob#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#output_location_type AiVisionStreamJob#output_location_type}.</summary>
            [JsiiProperty(name: "outputLocationType", typeJson: "{\"primitive\":\"string\"}")]
            public string OutputLocationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#prefix AiVisionStreamJob#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#obo_token AiVisionStreamJob#obo_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oboToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OboToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
