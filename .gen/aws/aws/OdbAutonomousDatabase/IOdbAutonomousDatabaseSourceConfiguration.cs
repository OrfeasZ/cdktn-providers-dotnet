using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfiguration), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfiguration")]
    public interface IOdbAutonomousDatabaseSourceConfiguration
    {
        /// <summary>clone_to_refreshable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_to_refreshable OdbAutonomousDatabase#clone_to_refreshable}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cloneToRefreshable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloneToRefreshable
        {
            get
            {
                return null;
            }
        }

        /// <summary>cross_region_data_guard block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cross_region_data_guard OdbAutonomousDatabase#cross_region_data_guard}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "crossRegionDataGuard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrossRegionDataGuard
        {
            get
            {
                return null;
            }
        }

        /// <summary>cross_region_disaster_recovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cross_region_disaster_recovery OdbAutonomousDatabase#cross_region_disaster_recovery}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "crossRegionDisasterRecovery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrossRegionDisasterRecovery
        {
            get
            {
                return null;
            }
        }

        /// <summary>database_clone block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#database_clone OdbAutonomousDatabase#database_clone}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationDatabaseClone" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "databaseClone", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationDatabaseClone\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DatabaseClone
        {
            get
            {
                return null;
            }
        }

        /// <summary>point_in_time_restore block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#point_in_time_restore OdbAutonomousDatabase#point_in_time_restore}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "pointInTimeRestore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationPointInTimeRestore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PointInTimeRestore
        {
            get
            {
                return null;
            }
        }

        /// <summary>restore_from_backup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#restore_from_backup OdbAutonomousDatabase#restore_from_backup}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "restoreFromBackup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationRestoreFromBackup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RestoreFromBackup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfiguration), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>clone_to_refreshable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_to_refreshable OdbAutonomousDatabase#clone_to_refreshable}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloneToRefreshable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloneToRefreshable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cross_region_data_guard block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cross_region_data_guard OdbAutonomousDatabase#cross_region_data_guard}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossRegionDataGuard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CrossRegionDataGuard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cross_region_disaster_recovery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cross_region_disaster_recovery OdbAutonomousDatabase#cross_region_disaster_recovery}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossRegionDisasterRecovery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CrossRegionDisasterRecovery
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database_clone block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#database_clone OdbAutonomousDatabase#database_clone}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationDatabaseClone" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseClone", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationDatabaseClone\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DatabaseClone
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>point_in_time_restore block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#point_in_time_restore OdbAutonomousDatabase#point_in_time_restore}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pointInTimeRestore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationPointInTimeRestore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PointInTimeRestore
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>restore_from_backup block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#restore_from_backup OdbAutonomousDatabase#restore_from_backup}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restoreFromBackup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationRestoreFromBackup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RestoreFromBackup
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
