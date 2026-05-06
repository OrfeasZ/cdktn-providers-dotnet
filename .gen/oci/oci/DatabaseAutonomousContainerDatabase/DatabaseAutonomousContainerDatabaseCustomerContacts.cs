using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseCustomerContacts")]
    public class DatabaseAutonomousContainerDatabaseCustomerContacts : oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseCustomerContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#email DatabaseAutonomousContainerDatabase#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }
    }
}
