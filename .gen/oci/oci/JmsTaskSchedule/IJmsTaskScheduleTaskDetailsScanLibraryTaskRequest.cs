using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest")]
    public interface IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#dynamic_scan_duration_in_minutes JmsTaskSchedule#dynamic_scan_duration_in_minutes}.</summary>
        [JsiiProperty(name: "dynamicScanDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DynamicScanDurationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#is_dynamic_scan JmsTaskSchedule#is_dynamic_scan}.</summary>
        [JsiiProperty(name: "isDynamicScan", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDynamicScan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_ids JmsTaskSchedule#managed_instance_ids}.</summary>
        [JsiiProperty(name: "managedInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ManagedInstanceIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#dynamic_scan_duration_in_minutes JmsTaskSchedule#dynamic_scan_duration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicScanDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DynamicScanDurationInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#is_dynamic_scan JmsTaskSchedule#is_dynamic_scan}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDynamicScan", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDynamicScan
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_ids JmsTaskSchedule#managed_instance_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ManagedInstanceIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
