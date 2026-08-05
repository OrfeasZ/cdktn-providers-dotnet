using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails")]
    public interface IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_scheduled_job#name OsManagementHubScheduledJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_scheduled_job#channel OsManagementHubScheduledJob#channel}.</summary>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Channel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_scheduled_job#name OsManagementHubScheduledJob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_scheduled_job#channel OsManagementHubScheduledJob#channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Channel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
