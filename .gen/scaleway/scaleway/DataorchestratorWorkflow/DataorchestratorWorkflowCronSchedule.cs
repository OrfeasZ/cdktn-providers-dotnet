using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataorchestratorWorkflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowCronSchedule")]
    public class DataorchestratorWorkflowCronSchedule : scaleway.DataorchestratorWorkflow.IDataorchestratorWorkflowCronSchedule
    {
        /// <summary>UNIX cron expression (e.g. `0 6 * * *`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#schedule DataorchestratorWorkflow#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public string Schedule
        {
            get;
            set;
        }

        /// <summary>Timezone in tz database format (e.g. `Europe/Paris`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#timezone_identifier DataorchestratorWorkflow#timezone_identifier}
        /// </remarks>
        [JsiiProperty(name: "timezoneIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string TimezoneIdentifier
        {
            get;
            set;
        }

        /// <summary>Overlap policy: `forbid`, `buffer_one`, `buffer_all`, or `allow_all`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#overlap DataorchestratorWorkflow#overlap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overlap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Overlap
        {
            get;
            set;
        }
    }
}
