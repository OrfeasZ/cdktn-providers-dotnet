using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetails")]
    public class DatascienceModelGroupModelGroupCloneSourceDetails : oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_clone_source_type DatascienceModelGroup#model_group_clone_source_type}.</summary>
        [JsiiProperty(name: "modelGroupCloneSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelGroupCloneSourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#source_id DatascienceModelGroup#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceId
        {
            get;
            set;
        }

        /// <summary>modify_model_group_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#modify_model_group_details DatascienceModelGroup#modify_model_group_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyModelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails\"}", isOptional: true)]
        public oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails? ModifyModelGroupDetails
        {
            get;
            set;
        }

        /// <summary>patch_model_group_member_model_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#patch_model_group_member_model_details DatascienceModelGroup#patch_model_group_member_model_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patchModelGroupMemberModelDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails\"}", isOptional: true)]
        public oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails? PatchModelGroupMemberModelDetails
        {
            get;
            set;
        }
    }
}
