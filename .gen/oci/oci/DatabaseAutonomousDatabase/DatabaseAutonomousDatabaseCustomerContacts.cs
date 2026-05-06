using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseCustomerContacts")]
    public class DatabaseAutonomousDatabaseCustomerContacts : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseCustomerContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#email DatabaseAutonomousDatabase#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }
    }
}
