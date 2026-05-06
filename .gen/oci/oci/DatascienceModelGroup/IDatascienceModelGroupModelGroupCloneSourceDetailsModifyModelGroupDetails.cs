using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails")]
    public interface IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#defined_tags DatascienceModelGroup#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#description DatascienceModelGroup#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#display_name DatascienceModelGroup#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#freeform_tags DatascienceModelGroup#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>model_group_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_details DatascienceModelGroup#model_group_details}
        /// </remarks>
        [JsiiProperty(name: "modelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails? ModelGroupDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_version_history_id DatascienceModelGroup#model_group_version_history_id}.</summary>
        [JsiiProperty(name: "modelGroupVersionHistoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelGroupVersionHistoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#version_label DatascienceModelGroup#version_label}.</summary>
        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#defined_tags DatascienceModelGroup#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#description DatascienceModelGroup#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#display_name DatascienceModelGroup#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#freeform_tags DatascienceModelGroup#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>model_group_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_details DatascienceModelGroup#model_group_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails\"}", isOptional: true)]
            public oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails? ModelGroupDetails
            {
                get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_group_version_history_id DatascienceModelGroup#model_group_version_history_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelGroupVersionHistoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelGroupVersionHistoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#version_label DatascienceModelGroup#version_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionLabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
