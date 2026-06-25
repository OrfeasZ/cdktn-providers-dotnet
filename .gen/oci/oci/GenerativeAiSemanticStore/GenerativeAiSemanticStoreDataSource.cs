using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSource")]
    public class GenerativeAiSemanticStoreDataSource : oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#connection_type GenerativeAiSemanticStore#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#enrichment_connection_id GenerativeAiSemanticStore#enrichment_connection_id}.</summary>
        [JsiiProperty(name: "enrichmentConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string EnrichmentConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#querying_connection_id GenerativeAiSemanticStore#querying_connection_id}.</summary>
        [JsiiProperty(name: "queryingConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string QueryingConnectionId
        {
            get;
            set;
        }
    }
}
