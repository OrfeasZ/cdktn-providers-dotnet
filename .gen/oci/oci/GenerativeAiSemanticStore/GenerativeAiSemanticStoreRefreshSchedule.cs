using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreRefreshSchedule")]
    public class GenerativeAiSemanticStoreRefreshSchedule : oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreRefreshSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_semantic_store#type GenerativeAiSemanticStore#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_semantic_store#value GenerativeAiSemanticStore#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
