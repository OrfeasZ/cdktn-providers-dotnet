using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobTrigger
{
    [JsiiInterface(nativeType: typeof(IJobTriggerCronConfig), fullyQualifiedName: "scaleway.jobTrigger.JobTriggerCronConfig")]
    public interface IJobTriggerCronConfig
    {
        /// <summary>The CRON schedule in UNIX format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#schedule JobTrigger#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        string Schedule
        {
            get;
        }

        /// <summary>The timezone for the CRON schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#timezone JobTrigger#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        /// <summary>The arguments passed to the startup command used by the triggered job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#args JobTrigger#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>The startup command that will be used by the triggered job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#startup_command JobTrigger#startup_command}
        /// </remarks>
        [JsiiProperty(name: "startupCommand", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StartupCommand
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJobTriggerCronConfig), fullyQualifiedName: "scaleway.jobTrigger.JobTriggerCronConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.JobTrigger.IJobTriggerCronConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The CRON schedule in UNIX format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#schedule JobTrigger#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
            public string Schedule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The timezone for the CRON schedule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#timezone JobTrigger#timezone}
            /// </remarks>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The arguments passed to the startup command used by the triggered job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#args JobTrigger#args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Args
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The startup command that will be used by the triggered job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/job_trigger#startup_command JobTrigger#startup_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startupCommand", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StartupCommand
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
