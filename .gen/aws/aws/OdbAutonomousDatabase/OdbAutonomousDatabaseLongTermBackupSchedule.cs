using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseLongTermBackupSchedule")]
    public class OdbAutonomousDatabaseLongTermBackupSchedule : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseLongTermBackupSchedule
    {
        private object? _isDisabled;

        /// <summary>Whether the long-term backup schedule is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#is_disabled OdbAutonomousDatabase#is_disabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDisabled
        {
            get => _isDisabled;
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
                _isDisabled = value;
            }
        }

        /// <summary>Cadence at which long-term backups are taken.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#repeat_cadence OdbAutonomousDatabase#repeat_cadence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repeatCadence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepeatCadence
        {
            get;
            set;
        }

        /// <summary>Retention period for long-term backups, in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#retention_period_in_days OdbAutonomousDatabase#retention_period_in_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriodInDays
        {
            get;
            set;
        }

        /// <summary>Date and time at which the long-term backup is taken.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#time_of_backup OdbAutonomousDatabase#time_of_backup}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfBackup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfBackup
        {
            get;
            set;
        }
    }
}
