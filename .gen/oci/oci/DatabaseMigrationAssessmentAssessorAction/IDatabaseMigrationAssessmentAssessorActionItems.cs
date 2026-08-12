using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessmentAssessorAction
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationAssessmentAssessorActionItems), fullyQualifiedName: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItems")]
    public interface IDatabaseMigrationAssessmentAssessorActionItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment_assessor_action#name DatabaseMigrationAssessmentAssessorAction#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment_assessor_action#value DatabaseMigrationAssessmentAssessorAction#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationAssessmentAssessorActionItems), fullyQualifiedName: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItems")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment_assessor_action#name DatabaseMigrationAssessmentAssessorAction#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment_assessor_action#value DatabaseMigrationAssessmentAssessorAction#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
