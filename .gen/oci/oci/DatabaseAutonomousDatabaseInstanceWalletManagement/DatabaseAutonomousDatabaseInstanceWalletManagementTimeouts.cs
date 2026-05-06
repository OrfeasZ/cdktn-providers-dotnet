using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseInstanceWalletManagement
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabaseInstanceWalletManagement.DatabaseAutonomousDatabaseInstanceWalletManagementTimeouts")]
    public class DatabaseAutonomousDatabaseInstanceWalletManagementTimeouts : oci.DatabaseAutonomousDatabaseInstanceWalletManagement.IDatabaseAutonomousDatabaseInstanceWalletManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_instance_wallet_management#create DatabaseAutonomousDatabaseInstanceWalletManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_instance_wallet_management#delete DatabaseAutonomousDatabaseInstanceWalletManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_instance_wallet_management#update DatabaseAutonomousDatabaseInstanceWalletManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
