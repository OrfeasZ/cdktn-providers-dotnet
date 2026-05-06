using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiByValue(fqn: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails")]
    public class DatascienceModelGroupMemberModelEntriesMemberModelDetails : oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#inference_key DatascienceModelGroup#inference_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferenceKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_id DatascienceModelGroup#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }
    }
}
