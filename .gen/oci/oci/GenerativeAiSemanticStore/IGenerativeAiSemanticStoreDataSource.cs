using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiSemanticStoreDataSource), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSource")]
    public interface IGenerativeAiSemanticStoreDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_semantic_store#connection_type GenerativeAiSemanticStore#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_semantic_store#enrichment_connection_id GenerativeAiSemanticStore#enrichment_connection_id}.</summary>
        [JsiiProperty(name: "enrichmentConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string EnrichmentConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_semantic_store#querying_connection_id GenerativeAiSemanticStore#querying_connection_id}.</summary>
        [JsiiProperty(name: "queryingConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string QueryingConnectionId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiSemanticStoreDataSource), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSource")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_semantic_store#connection_type GenerativeAiSemanticStore#connection_type}.</summary>
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_semantic_store#enrichment_connection_id GenerativeAiSemanticStore#enrichment_connection_id}.</summary>
            [JsiiProperty(name: "enrichmentConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string EnrichmentConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_semantic_store#querying_connection_id GenerativeAiSemanticStore#querying_connection_id}.</summary>
            [JsiiProperty(name: "queryingConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryingConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
