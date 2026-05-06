using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiByValue(fqn: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetails")]
    public class DatabaseExadataInfrastructureNetworkBondingModeDetails : oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#backup_network_bonding_mode DatabaseExadataInfrastructure#backup_network_bonding_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupNetworkBondingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#client_network_bonding_mode DatabaseExadataInfrastructure#client_network_bonding_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientNetworkBondingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#dr_network_bonding_mode DatabaseExadataInfrastructure#dr_network_bonding_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DrNetworkBondingMode
        {
            get;
            set;
        }
    }
}
