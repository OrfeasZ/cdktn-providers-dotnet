using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessmentAssessorAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItems")]
    public class DatabaseMigrationAssessmentAssessorActionItems : oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_migration_assessment_assessor_action#name DatabaseMigrationAssessmentAssessorAction#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_migration_assessment_assessor_action#value DatabaseMigrationAssessmentAssessorAction#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
