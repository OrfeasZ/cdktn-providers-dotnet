using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseExadataInfrastructureNetworkBondingModeDetails), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetails")]
    public interface IDatabaseExadataInfrastructureNetworkBondingModeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#backup_network_bonding_mode DatabaseExadataInfrastructure#backup_network_bonding_mode}.</summary>
        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupNetworkBondingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#client_network_bonding_mode DatabaseExadataInfrastructure#client_network_bonding_mode}.</summary>
        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientNetworkBondingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#dr_network_bonding_mode DatabaseExadataInfrastructure#dr_network_bonding_mode}.</summary>
        [JsiiProperty(name: "drNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DrNetworkBondingMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExadataInfrastructureNetworkBondingModeDetails), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#backup_network_bonding_mode DatabaseExadataInfrastructure#backup_network_bonding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupNetworkBondingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#client_network_bonding_mode DatabaseExadataInfrastructure#client_network_bonding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientNetworkBondingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#dr_network_bonding_mode DatabaseExadataInfrastructure#dr_network_bonding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DrNetworkBondingMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
