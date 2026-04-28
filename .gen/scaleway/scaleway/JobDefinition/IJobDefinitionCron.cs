using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    [JsiiInterface(nativeType: typeof(IJobDefinitionCron), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionCron")]
    public interface IJobDefinitionCron
    {
        /// <summary>UNIX cron schedule to run job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#schedule JobDefinition#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        string Schedule
        {
            get;
        }

        /// <summary>Timezone for the cron schedule, in tz database format (e.g., 'Europe/Paris').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#timezone JobDefinition#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IJobDefinitionCron), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionCron")]
        internal sealed class _Proxy : DeputyBase, scaleway.JobDefinition.IJobDefinitionCron
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UNIX cron schedule to run job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#schedule JobDefinition#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
            public string Schedule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Timezone for the cron schedule, in tz database format (e.g., 'Europe/Paris').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#timezone JobDefinition#timezone}
            /// </remarks>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
