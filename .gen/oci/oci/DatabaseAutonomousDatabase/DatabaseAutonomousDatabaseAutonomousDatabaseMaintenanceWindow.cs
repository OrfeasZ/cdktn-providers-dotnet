using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow")]
    public class DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow
    {
        /// <summary>day_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek\"}")]
        public oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#availability_domain DatabaseAutonomousDatabase#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        private object? _isMaintenanceWindowChangeScheduled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#is_maintenance_window_change_scheduled DatabaseAutonomousDatabase#is_maintenance_window_change_scheduled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isMaintenanceWindowChangeScheduled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMaintenanceWindowChangeScheduled
        {
            get => _isMaintenanceWindowChangeScheduled;
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
                _isMaintenanceWindowChangeScheduled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#maintenance_end_time DatabaseAutonomousDatabase#maintenance_end_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceEndTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#maintenance_start_time DatabaseAutonomousDatabase#maintenance_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceStartTime
        {
            get;
            set;
        }
    }
}
