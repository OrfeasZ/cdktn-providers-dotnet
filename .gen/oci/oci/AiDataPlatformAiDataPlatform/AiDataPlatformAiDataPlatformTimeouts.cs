using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDataPlatformAiDataPlatform
{
    [JsiiByValue(fqn: "oci.aiDataPlatformAiDataPlatform.AiDataPlatformAiDataPlatformTimeouts")]
    public class AiDataPlatformAiDataPlatformTimeouts : oci.AiDataPlatformAiDataPlatform.IAiDataPlatformAiDataPlatformTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_data_platform_ai_data_platform#create AiDataPlatformAiDataPlatform#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_data_platform_ai_data_platform#delete AiDataPlatformAiDataPlatform#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_data_platform_ai_data_platform#update AiDataPlatformAiDataPlatform#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
