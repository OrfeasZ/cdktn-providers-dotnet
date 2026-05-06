using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseSoftwareImage
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabaseSoftwareImage.DatabaseAutonomousDatabaseSoftwareImageTimeouts")]
    public class DatabaseAutonomousDatabaseSoftwareImageTimeouts : oci.DatabaseAutonomousDatabaseSoftwareImage.IDatabaseAutonomousDatabaseSoftwareImageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_software_image#create DatabaseAutonomousDatabaseSoftwareImage#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_software_image#delete DatabaseAutonomousDatabaseSoftwareImage#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_software_image#update DatabaseAutonomousDatabaseSoftwareImage#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
