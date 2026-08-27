using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiSemanticStoreSchemasSchemas), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas")]
    public interface IGenerativeAiSemanticStoreSchemasSchemas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_semantic_store#name GenerativeAiSemanticStore#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiSemanticStoreSchemasSchemas), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_semantic_store#name GenerativeAiSemanticStore#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
