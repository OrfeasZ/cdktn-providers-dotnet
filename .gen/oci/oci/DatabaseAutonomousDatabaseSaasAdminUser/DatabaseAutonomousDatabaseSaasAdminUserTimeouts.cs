using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseSaasAdminUser
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabaseSaasAdminUser.DatabaseAutonomousDatabaseSaasAdminUserTimeouts")]
    public class DatabaseAutonomousDatabaseSaasAdminUserTimeouts : oci.DatabaseAutonomousDatabaseSaasAdminUser.IDatabaseAutonomousDatabaseSaasAdminUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#create DatabaseAutonomousDatabaseSaasAdminUser#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#delete DatabaseAutonomousDatabaseSaasAdminUser#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#update DatabaseAutonomousDatabaseSaasAdminUser#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
