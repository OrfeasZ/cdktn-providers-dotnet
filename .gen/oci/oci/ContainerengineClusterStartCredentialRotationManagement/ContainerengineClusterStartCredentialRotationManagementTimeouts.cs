using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineClusterStartCredentialRotationManagement
{
    [JsiiByValue(fqn: "oci.containerengineClusterStartCredentialRotationManagement.ContainerengineClusterStartCredentialRotationManagementTimeouts")]
    public class ContainerengineClusterStartCredentialRotationManagementTimeouts : oci.ContainerengineClusterStartCredentialRotationManagement.IContainerengineClusterStartCredentialRotationManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_start_credential_rotation_management#create ContainerengineClusterStartCredentialRotationManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_start_credential_rotation_management#delete ContainerengineClusterStartCredentialRotationManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_start_credential_rotation_management#update ContainerengineClusterStartCredentialRotationManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
