using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestTargets), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestTargets")]
    public interface IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_installation_key JmsTaskSchedule#application_installation_key}.</summary>
        [JsiiProperty(name: "applicationInstallationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationInstallationKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_key JmsTaskSchedule#application_key}.</summary>
        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#container_key JmsTaskSchedule#container_key}.</summary>
        [JsiiProperty(name: "containerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jre_key JmsTaskSchedule#jre_key}.</summary>
        [JsiiProperty(name: "jreKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JreKey
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

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestTargets), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestTargets")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestTargets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_installation_key JmsTaskSchedule#application_installation_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationInstallationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationInstallationKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_key JmsTaskSchedule#application_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#container_key JmsTaskSchedule#container_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jre_key JmsTaskSchedule#jre_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jreKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JreKey
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
