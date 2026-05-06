using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    [JsiiInterface(nativeType: typeof(IAiDocumentModelModelSubType), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelModelSubType")]
    public interface IAiDocumentModelModelSubType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_sub_type AiDocumentModel#model_sub_type}.</summary>
        [JsiiProperty(name: "modelSubType", typeJson: "{\"primitive\":\"string\"}")]
        string ModelSubType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_type AiDocumentModel#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        string ModelType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentModelModelSubType), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelModelSubType")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentModel.IAiDocumentModelModelSubType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_sub_type AiDocumentModel#model_sub_type}.</summary>
            [JsiiProperty(name: "modelSubType", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelSubType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_type AiDocumentModel#model_type}.</summary>
            [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
