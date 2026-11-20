using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.jobTrigger.JobTriggerCronConfig")]
    public class JobTriggerCronConfig : scaleway.JobTrigger.IJobTriggerCronConfig
    {
        /// <summary>The CRON schedule in UNIX format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#schedule JobTrigger#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public string Schedule
        {
            get;
            set;
        }

        /// <summary>The timezone for the CRON schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#timezone JobTrigger#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public string Timezone
        {
            get;
            set;
        }

        /// <summary>The arguments passed to the startup command used by the triggered job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#args JobTrigger#args}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Args
        {
            get;
            set;
        }

        /// <summary>The startup command that will be used by the triggered job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#startup_command JobTrigger#startup_command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startupCommand", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? StartupCommand
        {
            get;
            set;
        }
    }
}
