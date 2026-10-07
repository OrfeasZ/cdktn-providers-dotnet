using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationPointInTimeRestore")]
    public interface IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore
    {
        /// <summary>Type of clone to create.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
        /// </remarks>
        [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
        string CloneType
        {
            get;
        }

        /// <summary>ID of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_id OdbAutonomousDatabase#source_autonomous_database_id}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAutonomousDatabaseId
        {
            get;
        }

        /// <summary>Tablespace IDs to clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_table_space_list OdbAutonomousDatabase#clone_table_space_list}
        /// </remarks>
        [JsiiProperty(name: "cloneTableSpaceList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? CloneTableSpaceList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date and time to which the database is restored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#timestamp OdbAutonomousDatabase#timestamp}
        /// </remarks>
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timestamp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to use the latest available backup timestamp.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#use_latest_available_backup_timestamp OdbAutonomousDatabase#use_latest_available_backup_timestamp}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useLatestAvailableBackupTimestamp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseLatestAvailableBackupTimestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationPointInTimeRestore")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of clone to create.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_type OdbAutonomousDatabase#clone_type}
            /// </remarks>
            [JsiiProperty(name: "cloneType", typeJson: "{\"primitive\":\"string\"}")]
            public string CloneType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the source Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_id OdbAutonomousDatabase#source_autonomous_database_id}
            /// </remarks>
            [JsiiProperty(name: "sourceAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAutonomousDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Tablespace IDs to clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_table_space_list OdbAutonomousDatabase#clone_table_space_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloneTableSpaceList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? CloneTableSpaceList
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Date and time to which the database is restored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#timestamp OdbAutonomousDatabase#timestamp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timestamp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to use the latest available backup timestamp.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#use_latest_available_backup_timestamp OdbAutonomousDatabase#use_latest_available_backup_timestamp}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useLatestAvailableBackupTimestamp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseLatestAvailableBackupTimestamp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
