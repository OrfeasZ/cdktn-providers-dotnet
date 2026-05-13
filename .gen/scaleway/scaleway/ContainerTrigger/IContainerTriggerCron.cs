using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    [JsiiInterface(nativeType: typeof(IContainerTriggerCron), fullyQualifiedName: "scaleway.containerTrigger.ContainerTriggerCron")]
    public interface IContainerTriggerCron
    {
        /// <summary>UNIX cron schedule to run job (e.g., "* * * * *").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#schedule ContainerTrigger#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        string Schedule
        {
            get;
        }

        /// <summary>Timezone for the cron schedule, in tz database format (e.g., "Europe/Paris").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#timezone ContainerTrigger#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        /// <summary>Body to send to the container when the trigger is invoked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#body ContainerTrigger#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional headers to send to the container when the trigger is invoked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#headers ContainerTrigger#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Headers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerTriggerCron), fullyQualifiedName: "scaleway.containerTrigger.ContainerTriggerCron")]
        internal sealed class _Proxy : DeputyBase, scaleway.ContainerTrigger.IContainerTriggerCron
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UNIX cron schedule to run job (e.g., "* * * * *").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#schedule ContainerTrigger#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
            public string Schedule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Timezone for the cron schedule, in tz database format (e.g., "Europe/Paris").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#timezone ContainerTrigger#timezone}
            /// </remarks>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Body to send to the container when the trigger is invoked.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#body ContainerTrigger#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Body
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Additional headers to send to the container when the trigger is invoked.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#headers ContainerTrigger#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Headers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
