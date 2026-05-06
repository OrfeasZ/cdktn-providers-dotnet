using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineClusterCompleteCredentialRotationManagement
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterCompleteCredentialRotationManagementTimeouts), fullyQualifiedName: "oci.containerengineClusterCompleteCredentialRotationManagement.ContainerengineClusterCompleteCredentialRotationManagementTimeouts")]
    public interface IContainerengineClusterCompleteCredentialRotationManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_complete_credential_rotation_management#create ContainerengineClusterCompleteCredentialRotationManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_complete_credential_rotation_management#delete ContainerengineClusterCompleteCredentialRotationManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_complete_credential_rotation_management#update ContainerengineClusterCompleteCredentialRotationManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterCompleteCredentialRotationManagementTimeouts), fullyQualifiedName: "oci.containerengineClusterCompleteCredentialRotationManagement.ContainerengineClusterCompleteCredentialRotationManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineClusterCompleteCredentialRotationManagement.IContainerengineClusterCompleteCredentialRotationManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_complete_credential_rotation_management#create ContainerengineClusterCompleteCredentialRotationManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_complete_credential_rotation_management#delete ContainerengineClusterCompleteCredentialRotationManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster_complete_credential_rotation_management#update ContainerengineClusterCompleteCredentialRotationManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
