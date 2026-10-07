using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseScheduledOperations")]
    public class OdbAutonomousDatabaseScheduledOperations : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseScheduledOperations
    {
        /// <summary>Day of the week.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#day_of_week OdbAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Scheduled start time in UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_start_time OdbAutonomousDatabase#scheduled_start_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduledStartTime
        {
            get;
            set;
        }

        /// <summary>Scheduled stop time in UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#scheduled_stop_time OdbAutonomousDatabase#scheduled_stop_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledStopTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduledStopTime
        {
            get;
            set;
        }
    }
}
