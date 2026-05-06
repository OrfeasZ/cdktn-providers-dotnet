using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseRegionalWalletManagement
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabaseRegionalWalletManagement.DatabaseAutonomousDatabaseRegionalWalletManagementTimeouts")]
    public class DatabaseAutonomousDatabaseRegionalWalletManagementTimeouts : oci.DatabaseAutonomousDatabaseRegionalWalletManagement.IDatabaseAutonomousDatabaseRegionalWalletManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_regional_wallet_management#create DatabaseAutonomousDatabaseRegionalWalletManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_regional_wallet_management#delete DatabaseAutonomousDatabaseRegionalWalletManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_regional_wallet_management#update DatabaseAutonomousDatabaseRegionalWalletManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
