using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiByValue(fqn: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreTimeouts")]
    public class GenerativeAiSemanticStoreTimeouts : oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#create GenerativeAiSemanticStore#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#delete GenerativeAiSemanticStore#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#update GenerativeAiSemanticStore#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
