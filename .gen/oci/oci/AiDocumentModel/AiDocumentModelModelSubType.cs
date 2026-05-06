using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiDocumentModel.AiDocumentModelModelSubType")]
    public class AiDocumentModelModelSubType : oci.AiDocumentModel.IAiDocumentModelModelSubType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_sub_type AiDocumentModel#model_sub_type}.</summary>
        [JsiiProperty(name: "modelSubType", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelSubType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#model_type AiDocumentModel#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelType
        {
            get;
            set;
        }
    }
}
