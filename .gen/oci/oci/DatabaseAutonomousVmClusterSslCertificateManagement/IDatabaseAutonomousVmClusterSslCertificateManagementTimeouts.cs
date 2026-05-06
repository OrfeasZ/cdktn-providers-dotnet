using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterSslCertificateManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts), fullyQualifiedName: "oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeouts")]
    public interface IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#create DatabaseAutonomousVmClusterSslCertificateManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#delete DatabaseAutonomousVmClusterSslCertificateManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#update DatabaseAutonomousVmClusterSslCertificateManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts), fullyQualifiedName: "oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousVmClusterSslCertificateManagement.IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#create DatabaseAutonomousVmClusterSslCertificateManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#delete DatabaseAutonomousVmClusterSslCertificateManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#update DatabaseAutonomousVmClusterSslCertificateManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
