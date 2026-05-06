using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterSslCertificateManagement
{
    [JsiiByValue(fqn: "oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeouts")]
    public class DatabaseAutonomousVmClusterSslCertificateManagementTimeouts : oci.DatabaseAutonomousVmClusterSslCertificateManagement.IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#create DatabaseAutonomousVmClusterSslCertificateManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#delete DatabaseAutonomousVmClusterSslCertificateManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#update DatabaseAutonomousVmClusterSslCertificateManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
