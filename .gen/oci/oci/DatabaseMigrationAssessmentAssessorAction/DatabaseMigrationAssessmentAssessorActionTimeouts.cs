using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessmentAssessorAction
{
    [JsiiByValue(fqn: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeouts")]
    public class DatabaseMigrationAssessmentAssessorActionTimeouts : oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_migration_assessment_assessor_action#create DatabaseMigrationAssessmentAssessorAction#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_migration_assessment_assessor_action#delete DatabaseMigrationAssessmentAssessorAction#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_migration_assessment_assessor_action#update DatabaseMigrationAssessmentAssessorAction#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
