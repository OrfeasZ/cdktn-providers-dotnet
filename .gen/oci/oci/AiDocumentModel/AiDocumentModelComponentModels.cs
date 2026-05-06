using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    [JsiiByValue(fqn: "oci.aiDocumentModel.AiDocumentModelComponentModels")]
    public class AiDocumentModelComponentModels : oci.AiDocumentModel.IAiDocumentModelComponentModels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_id AiDocumentModel#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }
    }
}
