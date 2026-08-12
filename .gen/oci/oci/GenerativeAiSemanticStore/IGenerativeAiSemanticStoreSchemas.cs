using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiSemanticStoreSchemas), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemas")]
    public interface IGenerativeAiSemanticStoreSchemas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#connection_type GenerativeAiSemanticStore#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionType
        {
            get;
        }

        /// <summary>schemas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#schemas GenerativeAiSemanticStore#schemas}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schemas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas\"},\"kind\":\"array\"}}]}}")]
        object Schemas
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiSemanticStoreSchemas), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemas")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#connection_type GenerativeAiSemanticStore#connection_type}.</summary>
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schemas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_semantic_store#schemas GenerativeAiSemanticStore#schemas}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "schemas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas\"},\"kind\":\"array\"}}]}}")]
            public object Schemas
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
