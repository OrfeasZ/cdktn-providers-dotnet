using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworksNodes")]
    public class DatabaseVmClusterNetworkVmNetworksNodes : oci.DatabaseVmClusterNetwork.IDatabaseVmClusterNetworkVmNetworksNodes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#hostname DatabaseVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#ip DatabaseVmClusterNetwork#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#db_server_id DatabaseVmClusterNetwork#db_server_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbServerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#state DatabaseVmClusterNetwork#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vip DatabaseVmClusterNetwork#vip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vip_hostname DatabaseVmClusterNetwork#vip_hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VipHostname
        {
            get;
            set;
        }
    }
}
