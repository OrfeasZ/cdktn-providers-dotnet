using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceNodeBackupConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsInstanceNodeBackupConfiguration.BdsBdsInstanceNodeBackupConfigurationLevelTypeDetails")]
    public class BdsBdsInstanceNodeBackupConfigurationLevelTypeDetails : oci.BdsBdsInstanceNodeBackupConfiguration.IBdsBdsInstanceNodeBackupConfigurationLevelTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#level_type BdsBdsInstanceNodeBackupConfiguration#level_type}.</summary>
        [JsiiProperty(name: "levelType", typeJson: "{\"primitive\":\"string\"}")]
        public string LevelType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#node_host_name BdsBdsInstanceNodeBackupConfiguration#node_host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeHostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_backup_configuration#node_type BdsBdsInstanceNodeBackupConfiguration#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }
    }
}
