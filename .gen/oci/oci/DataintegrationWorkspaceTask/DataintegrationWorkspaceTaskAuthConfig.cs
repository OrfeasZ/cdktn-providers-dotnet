using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfig")]
    public class DataintegrationWorkspaceTaskAuthConfig : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_type DataintegrationWorkspaceTask#model_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_version DataintegrationWorkspaceTask#model_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelVersion
        {
            get;
            set;
        }

        /// <summary>parent_ref block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfigParentRef\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfigParentRef? ParentRef
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#resource_principal_source DataintegrationWorkspaceTask#resource_principal_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourcePrincipalSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourcePrincipalSource
        {
            get;
            set;
        }
    }
}
