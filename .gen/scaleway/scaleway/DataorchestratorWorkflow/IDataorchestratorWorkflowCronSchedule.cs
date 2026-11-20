using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataorchestratorWorkflow
{
    [JsiiInterface(nativeType: typeof(IDataorchestratorWorkflowCronSchedule), fullyQualifiedName: "scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowCronSchedule")]
    public interface IDataorchestratorWorkflowCronSchedule
    {
        /// <summary>UNIX cron expression (e.g. `0 6 * * *`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#schedule DataorchestratorWorkflow#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        string Schedule
        {
            get;
        }

        /// <summary>Timezone in tz database format (e.g. `Europe/Paris`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#timezone_identifier DataorchestratorWorkflow#timezone_identifier}
        /// </remarks>
        [JsiiProperty(name: "timezoneIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string TimezoneIdentifier
        {
            get;
        }

        /// <summary>Overlap policy: `forbid`, `buffer_one`, `buffer_all`, or `allow_all`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#overlap DataorchestratorWorkflow#overlap}
        /// </remarks>
        [JsiiProperty(name: "overlap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Overlap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataorchestratorWorkflowCronSchedule), fullyQualifiedName: "scaleway.dataorchestratorWorkflow.DataorchestratorWorkflowCronSchedule")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataorchestratorWorkflow.IDataorchestratorWorkflowCronSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UNIX cron expression (e.g. `0 6 * * *`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#schedule DataorchestratorWorkflow#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
            public string Schedule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Timezone in tz database format (e.g. `Europe/Paris`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#timezone_identifier DataorchestratorWorkflow#timezone_identifier}
            /// </remarks>
            [JsiiProperty(name: "timezoneIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string TimezoneIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Overlap policy: `forbid`, `buffer_one`, `buffer_all`, or `allow_all`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/dataorchestrator_workflow#overlap DataorchestratorWorkflow#overlap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overlap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Overlap
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
