using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery")]
    public class OdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseSourceConfigurationCrossRegionDisasterRecovery
    {
        /// <summary>Type of remote disaster recovery.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#remote_disaster_recovery_type OdbAutonomousDatabase#remote_disaster_recovery_type}
        /// </remarks>
        [JsiiProperty(name: "remoteDisasterRecoveryType", typeJson: "{\"primitive\":\"string\"}")]
        public string RemoteDisasterRecoveryType
        {
            get;
            set;
        }

        /// <summary>ARN of the source Autonomous Database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#source_autonomous_database_arn OdbAutonomousDatabase#source_autonomous_database_arn}
        /// </remarks>
        [JsiiProperty(name: "sourceAutonomousDatabaseArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceAutonomousDatabaseArn
        {
            get;
            set;
        }

        private object? _isReplicateAutomaticBackups;

        /// <summary>Whether automatic backups are replicated to the disaster recovery database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_replicate_automatic_backups OdbAutonomousDatabase#is_replicate_automatic_backups}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isReplicateAutomaticBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsReplicateAutomaticBackups
        {
            get => _isReplicateAutomaticBackups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isReplicateAutomaticBackups = value;
            }
        }
    }
}
