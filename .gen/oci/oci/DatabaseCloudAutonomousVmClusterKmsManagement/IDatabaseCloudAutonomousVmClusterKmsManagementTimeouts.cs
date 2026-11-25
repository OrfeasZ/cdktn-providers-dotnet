using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudAutonomousVmClusterKmsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudAutonomousVmClusterKmsManagementTimeouts), fullyQualifiedName: "oci.databaseCloudAutonomousVmClusterKmsManagement.DatabaseCloudAutonomousVmClusterKmsManagementTimeouts")]
    public interface IDatabaseCloudAutonomousVmClusterKmsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#create DatabaseCloudAutonomousVmClusterKmsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#delete DatabaseCloudAutonomousVmClusterKmsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#update DatabaseCloudAutonomousVmClusterKmsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudAutonomousVmClusterKmsManagementTimeouts), fullyQualifiedName: "oci.databaseCloudAutonomousVmClusterKmsManagement.DatabaseCloudAutonomousVmClusterKmsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudAutonomousVmClusterKmsManagement.IDatabaseCloudAutonomousVmClusterKmsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#create DatabaseCloudAutonomousVmClusterKmsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#delete DatabaseCloudAutonomousVmClusterKmsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#update DatabaseCloudAutonomousVmClusterKmsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
