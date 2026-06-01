using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.containerTrigger.ContainerTriggerCron")]
    public class ContainerTriggerCron : scaleway.ContainerTrigger.IContainerTriggerCron
    {
        /// <summary>UNIX cron schedule to run job (e.g., "* * * * *").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#schedule ContainerTrigger#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public string Schedule
        {
            get;
            set;
        }

        /// <summary>Timezone for the cron schedule, in tz database format (e.g., "Europe/Paris").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#timezone ContainerTrigger#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public string Timezone
        {
            get;
            set;
        }

        /// <summary>Body to send to the container when the trigger is invoked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#body ContainerTrigger#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Body
        {
            get;
            set;
        }

        /// <summary>Additional headers to send to the container when the trigger is invoked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#headers ContainerTrigger#headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Headers
        {
            get;
            set;
        }
    }
}
