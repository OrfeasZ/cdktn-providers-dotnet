using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessment
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationAssessmentConfig), fullyQualifiedName: "oci.databaseMigrationAssessment.DatabaseMigrationAssessmentConfig")]
    public interface IDatabaseMigrationAssessmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#acceptable_downtime DatabaseMigrationAssessment#acceptable_downtime}.</summary>
        [JsiiProperty(name: "acceptableDowntime", typeJson: "{\"primitive\":\"string\"}")]
        string AcceptableDowntime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#compartment_id DatabaseMigrationAssessment#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#database_combination DatabaseMigrationAssessment#database_combination}.</summary>
        [JsiiProperty(name: "databaseCombination", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseCombination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#database_data_size DatabaseMigrationAssessment#database_data_size}.</summary>
        [JsiiProperty(name: "databaseDataSize", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseDataSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#ddl_expectation DatabaseMigrationAssessment#ddl_expectation}.</summary>
        [JsiiProperty(name: "ddlExpectation", typeJson: "{\"primitive\":\"string\"}")]
        string DdlExpectation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#network_speed_megabit_per_second DatabaseMigrationAssessment#network_speed_megabit_per_second}.</summary>
        [JsiiProperty(name: "networkSpeedMegabitPerSecond", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkSpeedMegabitPerSecond
        {
            get;
        }

        /// <summary>source_database_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#source_database_connection DatabaseMigrationAssessment#source_database_connection}
        /// </remarks>
        [JsiiProperty(name: "sourceDatabaseConnection", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnection\"}")]
        oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection SourceDatabaseConnection
        {
            get;
        }

        /// <summary>target_database_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#target_database_connection DatabaseMigrationAssessment#target_database_connection}
        /// </remarks>
        [JsiiProperty(name: "targetDatabaseConnection", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection\"}")]
        oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection TargetDatabaseConnection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#bulk_include_exclude_data DatabaseMigrationAssessment#bulk_include_exclude_data}.</summary>
        [JsiiProperty(name: "bulkIncludeExcludeData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BulkIncludeExcludeData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#creation_type DatabaseMigrationAssessment#creation_type}.</summary>
        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#defined_tags DatabaseMigrationAssessment#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#description DatabaseMigrationAssessment#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#display_name DatabaseMigrationAssessment#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>exclude_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#exclude_objects DatabaseMigrationAssessment#exclude_objects}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "excludeObjects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeObjects
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#freeform_tags DatabaseMigrationAssessment#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#id DatabaseMigrationAssessment#id}.</summary>
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

        /// <summary>include_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#include_objects DatabaseMigrationAssessment#include_objects}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "includeObjects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeObjects
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#timeouts DatabaseMigrationAssessment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationAssessmentConfig), fullyQualifiedName: "oci.databaseMigrationAssessment.DatabaseMigrationAssessmentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#acceptable_downtime DatabaseMigrationAssessment#acceptable_downtime}.</summary>
            [JsiiProperty(name: "acceptableDowntime", typeJson: "{\"primitive\":\"string\"}")]
            public string AcceptableDowntime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#compartment_id DatabaseMigrationAssessment#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#database_combination DatabaseMigrationAssessment#database_combination}.</summary>
            [JsiiProperty(name: "databaseCombination", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseCombination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#database_data_size DatabaseMigrationAssessment#database_data_size}.</summary>
            [JsiiProperty(name: "databaseDataSize", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseDataSize
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#ddl_expectation DatabaseMigrationAssessment#ddl_expectation}.</summary>
            [JsiiProperty(name: "ddlExpectation", typeJson: "{\"primitive\":\"string\"}")]
            public string DdlExpectation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#network_speed_megabit_per_second DatabaseMigrationAssessment#network_speed_megabit_per_second}.</summary>
            [JsiiProperty(name: "networkSpeedMegabitPerSecond", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkSpeedMegabitPerSecond
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source_database_connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#source_database_connection DatabaseMigrationAssessment#source_database_connection}
            /// </remarks>
            [JsiiProperty(name: "sourceDatabaseConnection", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnection\"}")]
            public oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection SourceDatabaseConnection
            {
                get => GetInstanceProperty<oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection>()!;
            }

            /// <summary>target_database_connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#target_database_connection DatabaseMigrationAssessment#target_database_connection}
            /// </remarks>
            [JsiiProperty(name: "targetDatabaseConnection", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection\"}")]
            public oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection TargetDatabaseConnection
            {
                get => GetInstanceProperty<oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#bulk_include_exclude_data DatabaseMigrationAssessment#bulk_include_exclude_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bulkIncludeExcludeData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BulkIncludeExcludeData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#creation_type DatabaseMigrationAssessment#creation_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#defined_tags DatabaseMigrationAssessment#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#description DatabaseMigrationAssessment#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#display_name DatabaseMigrationAssessment#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>exclude_objects block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#exclude_objects DatabaseMigrationAssessment#exclude_objects}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeObjects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExcludeObjects
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#freeform_tags DatabaseMigrationAssessment#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#id DatabaseMigrationAssessment#id}.</summary>
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

            /// <summary>include_objects block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#include_objects DatabaseMigrationAssessment#include_objects}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeObjects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IncludeObjects
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_migration_assessment#timeouts DatabaseMigrationAssessment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTimeouts\"}", isOptional: true)]
            public oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
