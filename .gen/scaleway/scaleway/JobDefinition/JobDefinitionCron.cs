using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.jobDefinition.JobDefinitionCron")]
    public class JobDefinitionCron : scaleway.JobDefinition.IJobDefinitionCron
    {
        /// <summary>UNIX cron schedule to run job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#schedule JobDefinition#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public string Schedule
        {
            get;
            set;
        }

        /// <summary>Timezone for the cron schedule, in tz database format (e.g., 'Europe/Paris').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#timezone JobDefinition#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public string Timezone
        {
            get;
            set;
        }
    }
}
