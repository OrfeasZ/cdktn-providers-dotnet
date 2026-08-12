using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessment
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationAssessmentTargetDatabaseConnection), fullyQualifiedName: "oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection")]
    public interface IDatabaseMigrationAssessmentTargetDatabaseConnection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#connection_type DatabaseMigrationAssessment#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#database_version DatabaseMigrationAssessment#database_version}.</summary>
        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#id DatabaseMigrationAssessment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#technology_sub_type DatabaseMigrationAssessment#technology_sub_type}.</summary>
        [JsiiProperty(name: "technologySubType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TechnologySubType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#technology_type DatabaseMigrationAssessment#technology_type}.</summary>
        [JsiiProperty(name: "technologyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TechnologyType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationAssessmentTargetDatabaseConnection), fullyQualifiedName: "oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#connection_type DatabaseMigrationAssessment#connection_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#database_version DatabaseMigrationAssessment#database_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#id DatabaseMigrationAssessment#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#technology_sub_type DatabaseMigrationAssessment#technology_sub_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "technologySubType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TechnologySubType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_migration_assessment#technology_type DatabaseMigrationAssessment#technology_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "technologyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TechnologyType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
