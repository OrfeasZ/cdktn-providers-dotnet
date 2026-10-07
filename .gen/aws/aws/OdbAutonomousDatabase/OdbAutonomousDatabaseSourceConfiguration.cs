using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfiguration")]
    public class OdbAutonomousDatabaseSourceConfiguration : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfiguration
    {
        private object? _cloneToRefreshable;

        /// <summary>clone_to_refreshable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#clone_to_refreshable OdbAutonomousDatabase#clone_to_refreshable}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloneToRefreshable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCloneToRefreshable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloneToRefreshable
        {
            get => _cloneToRefreshable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCloneToRefreshable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cloneToRefreshable = value;
            }
        }

        private object? _crossRegionDataGuard;

        /// <summary>cross_region_data_guard block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cross_region_data_guard OdbAutonomousDatabase#cross_region_data_guard}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crossRegionDataGuard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CrossRegionDataGuard
        {
            get => _crossRegionDataGuard;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDataGuard).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _crossRegionDataGuard = value;
            }
        }

        private object? _crossRegionDisasterRecovery;

        /// <summary>cross_region_disaster_recovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#cross_region_disaster_recovery OdbAutonomousDatabase#cross_region_disaster_recovery}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crossRegionDisasterRecovery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CrossRegionDisasterRecovery
        {
            get => _crossRegionDisasterRecovery;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _crossRegionDisasterRecovery = value;
            }
        }

        private object? _databaseClone;

        /// <summary>database_clone block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#database_clone OdbAutonomousDatabase#database_clone}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationDatabaseClone" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseClone", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationDatabaseClone\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DatabaseClone
        {
            get => _databaseClone;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationDatabaseClone[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationDatabaseClone).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _databaseClone = value;
            }
        }

        private object? _pointInTimeRestore;

        /// <summary>point_in_time_restore block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#point_in_time_restore OdbAutonomousDatabase#point_in_time_restore}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRestore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationPointInTimeRestore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PointInTimeRestore
        {
            get => _pointInTimeRestore;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationPointInTimeRestore).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pointInTimeRestore = value;
            }
        }

        private object? _restoreFromBackup;

        /// <summary>restore_from_backup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#restore_from_backup OdbAutonomousDatabase#restore_from_backup}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restoreFromBackup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationRestoreFromBackup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RestoreFromBackup
        {
            get => _restoreFromBackup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationRestoreFromBackup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _restoreFromBackup = value;
            }
        }
    }
}
