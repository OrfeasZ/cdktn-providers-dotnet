using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites")]
    public interface IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_key JmsTaskSchedule#installation_key}.</summary>
        [JsiiProperty(name: "installationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstallationKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_id JmsTaskSchedule#managed_instance_id}.</summary>
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedInstanceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_key JmsTaskSchedule#installation_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "installationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstallationKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_id JmsTaskSchedule#managed_instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedInstanceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
