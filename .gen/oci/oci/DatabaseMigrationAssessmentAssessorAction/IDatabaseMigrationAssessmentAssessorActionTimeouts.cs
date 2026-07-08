using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessmentAssessorAction
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationAssessmentAssessorActionTimeouts), fullyQualifiedName: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeouts")]
    public interface IDatabaseMigrationAssessmentAssessorActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_migration_assessment_assessor_action#create DatabaseMigrationAssessmentAssessorAction#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_migration_assessment_assessor_action#delete DatabaseMigrationAssessmentAssessorAction#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_migration_assessment_assessor_action#update DatabaseMigrationAssessmentAssessorAction#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationAssessmentAssessorActionTimeouts), fullyQualifiedName: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_migration_assessment_assessor_action#create DatabaseMigrationAssessmentAssessorAction#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_migration_assessment_assessor_action#delete DatabaseMigrationAssessmentAssessorAction#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_migration_assessment_assessor_action#update DatabaseMigrationAssessmentAssessorAction#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
