using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest")]
    public interface IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest
    {
        /// <summary>installation_sites block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_sites JmsTaskSchedule#installation_sites}
        /// </remarks>
        [JsiiProperty(name: "installationSites", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstallationSites
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>installation_sites block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_sites JmsTaskSchedule#installation_sites}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "installationSites", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InstallationSites
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
