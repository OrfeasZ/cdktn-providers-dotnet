using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseScheduledOperations), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseScheduledOperations")]
    public interface IOdbAutonomousDatabaseScheduledOperations
    {
        /// <summary>Day of the week.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#day_of_week OdbAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        /// <summary>Scheduled start time in UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_start_time OdbAutonomousDatabase#scheduled_start_time}
        /// </remarks>
        [JsiiProperty(name: "scheduledStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scheduled stop time in UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_stop_time OdbAutonomousDatabase#scheduled_stop_time}
        /// </remarks>
        [JsiiProperty(name: "scheduledStopTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledStopTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseScheduledOperations), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseScheduledOperations")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseScheduledOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Day of the week.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#day_of_week OdbAutonomousDatabase#day_of_week}
            /// </remarks>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Scheduled start time in UTC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_start_time OdbAutonomousDatabase#scheduled_start_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Scheduled stop time in UTC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_stop_time OdbAutonomousDatabase#scheduled_stop_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledStopTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledStopTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
