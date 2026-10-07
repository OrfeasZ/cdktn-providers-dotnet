using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery")]
    public interface IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery
    {
        /// <summary>Type of remote disaster recovery.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#remote_disaster_recovery_type OdbAutonomousDatabase#remote_disaster_recovery_type}
        /// </remarks>
        [JsiiProperty(name: "remoteDisasterRecoveryType", typeJson: "{\"primitive\":\"string\"}")]
        string RemoteDisasterRecoveryType
        {
            get;
        }

        /// <summary>ARN of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_arn OdbAutonomousDatabase#source_autonomous_database_arn}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseArn", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAutonomousDatabaseArn
        {
            get;
        }

        /// <summary>Whether automatic backups are replicated to the disaster recovery database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_replicate_automatic_backups OdbAutonomousDatabase#is_replicate_automatic_backups}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isReplicateAutomaticBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsReplicateAutomaticBackups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of remote disaster recovery.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#remote_disaster_recovery_type OdbAutonomousDatabase#remote_disaster_recovery_type}
            /// </remarks>
            [JsiiProperty(name: "remoteDisasterRecoveryType", typeJson: "{\"primitive\":\"string\"}")]
            public string RemoteDisasterRecoveryType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the source Autonomous Database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_arn OdbAutonomousDatabase#source_autonomous_database_arn}
            /// </remarks>
            [JsiiProperty(name: "sourceAutonomousDatabaseArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAutonomousDatabaseArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether automatic backups are replicated to the disaster recovery database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_replicate_automatic_backups OdbAutonomousDatabase#is_replicate_automatic_backups}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isReplicateAutomaticBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsReplicateAutomaticBackups
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
