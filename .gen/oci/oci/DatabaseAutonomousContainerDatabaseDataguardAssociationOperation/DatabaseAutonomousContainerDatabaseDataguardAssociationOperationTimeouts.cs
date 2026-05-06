using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation
{
    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts")]
    public class DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts : oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.IDatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association_operation#create DatabaseAutonomousContainerDatabaseDataguardAssociationOperation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association_operation#delete DatabaseAutonomousContainerDatabaseDataguardAssociationOperation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
