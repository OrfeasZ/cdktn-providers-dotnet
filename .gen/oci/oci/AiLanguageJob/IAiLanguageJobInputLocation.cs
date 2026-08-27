using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    [JsiiInterface(nativeType: typeof(IAiLanguageJobInputLocation), fullyQualifiedName: "oci.aiLanguageJob.AiLanguageJobInputLocation")]
    public interface IAiLanguageJobInputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#bucket AiLanguageJob#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#location_type AiLanguageJob#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        string LocationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#namespace AiLanguageJob#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#object_names AiLanguageJob#object_names}.</summary>
        [JsiiProperty(name: "objectNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ObjectNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageJobInputLocation), fullyQualifiedName: "oci.aiLanguageJob.AiLanguageJobInputLocation")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageJob.IAiLanguageJobInputLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#bucket AiLanguageJob#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#location_type AiLanguageJob#location_type}.</summary>
            [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#namespace AiLanguageJob#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#object_names AiLanguageJob#object_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ObjectNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
