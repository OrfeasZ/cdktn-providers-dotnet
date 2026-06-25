using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessment
{
    [JsiiByValue(fqn: "oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection")]
    public class DatabaseMigrationAssessmentTargetDatabaseConnection : oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment#connection_type DatabaseMigrationAssessment#connection_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment#database_version DatabaseMigrationAssessment#database_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment#id DatabaseMigrationAssessment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment#technology_sub_type DatabaseMigrationAssessment#technology_sub_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "technologySubType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TechnologySubType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment#technology_type DatabaseMigrationAssessment#technology_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "technologyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TechnologyType
        {
            get;
            set;
        }
    }
}
