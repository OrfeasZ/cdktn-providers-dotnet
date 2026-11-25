using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterKmsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousVmClusterKmsManagementTimeouts), fullyQualifiedName: "oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeouts")]
    public interface IDatabaseAutonomousVmClusterKmsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#create DatabaseAutonomousVmClusterKmsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#delete DatabaseAutonomousVmClusterKmsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#update DatabaseAutonomousVmClusterKmsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousVmClusterKmsManagementTimeouts), fullyQualifiedName: "oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#create DatabaseAutonomousVmClusterKmsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#delete DatabaseAutonomousVmClusterKmsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#update DatabaseAutonomousVmClusterKmsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
