using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    [JsiiInterface(nativeType: typeof(IAiDocumentModelComponentModels), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelComponentModels")]
    public interface IAiDocumentModelComponentModels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_id AiDocumentModel#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentModelComponentModels), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelComponentModels")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentModel.IAiDocumentModelComponentModels
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_id AiDocumentModel#model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
