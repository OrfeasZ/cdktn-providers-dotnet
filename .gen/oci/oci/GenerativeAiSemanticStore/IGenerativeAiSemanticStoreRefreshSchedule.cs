using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiSemanticStoreRefreshSchedule), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreRefreshSchedule")]
    public interface IGenerativeAiSemanticStoreRefreshSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#type GenerativeAiSemanticStore#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#value GenerativeAiSemanticStore#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiSemanticStoreRefreshSchedule), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreRefreshSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreRefreshSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#type GenerativeAiSemanticStore#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/generative_ai_semantic_store#value GenerativeAiSemanticStore#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
