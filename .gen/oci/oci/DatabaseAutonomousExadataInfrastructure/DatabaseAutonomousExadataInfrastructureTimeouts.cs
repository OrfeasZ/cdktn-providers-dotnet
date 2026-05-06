using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousExadataInfrastructure
{
    [JsiiByValue(fqn: "oci.databaseAutonomousExadataInfrastructure.DatabaseAutonomousExadataInfrastructureTimeouts")]
    public class DatabaseAutonomousExadataInfrastructureTimeouts : oci.DatabaseAutonomousExadataInfrastructure.IDatabaseAutonomousExadataInfrastructureTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_exadata_infrastructure#create DatabaseAutonomousExadataInfrastructure#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_exadata_infrastructure#delete DatabaseAutonomousExadataInfrastructure#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_exadata_infrastructure#update DatabaseAutonomousExadataInfrastructure#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
