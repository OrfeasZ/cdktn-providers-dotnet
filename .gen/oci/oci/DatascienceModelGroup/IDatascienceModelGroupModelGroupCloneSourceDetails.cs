using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelGroupModelGroupCloneSourceDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetails")]
    public interface IDatascienceModelGroupModelGroupCloneSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_clone_source_type DatascienceModelGroup#model_group_clone_source_type}.</summary>
        [JsiiProperty(name: "modelGroupCloneSourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ModelGroupCloneSourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#source_id DatascienceModelGroup#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceId
        {
            get;
        }

        /// <summary>modify_model_group_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#modify_model_group_details DatascienceModelGroup#modify_model_group_details}
        /// </remarks>
        [JsiiProperty(name: "modifyModelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails? ModifyModelGroupDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>patch_model_group_member_model_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#patch_model_group_member_model_details DatascienceModelGroup#patch_model_group_member_model_details}
        /// </remarks>
        [JsiiProperty(name: "patchModelGroupMemberModelDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails? PatchModelGroupMemberModelDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelGroupModelGroupCloneSourceDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_clone_source_type DatascienceModelGroup#model_group_clone_source_type}.</summary>
            [JsiiProperty(name: "modelGroupCloneSourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelGroupCloneSourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#source_id DatascienceModelGroup#source_id}.</summary>
            [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>modify_model_group_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#modify_model_group_details DatascienceModelGroup#modify_model_group_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyModelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails\"}", isOptional: true)]
            public oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails? ModifyModelGroupDetails
            {
                get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails?>();
            }

            /// <summary>patch_model_group_member_model_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#patch_model_group_member_model_details DatascienceModelGroup#patch_model_group_member_model_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchModelGroupMemberModelDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails\"}", isOptional: true)]
            public oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails? PatchModelGroupMemberModelDetails
            {
                get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails?>();
            }
        }
    }
}
