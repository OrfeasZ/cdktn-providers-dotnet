using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskSchedules), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskSchedules")]
    public interface ILogAnalyticsNamespaceScheduledTaskSchedules
    {
        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#schedule LogAnalyticsNamespaceScheduledTask#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskSchedulesSchedule\"},\"kind\":\"array\"}}]}}")]
        object Schedule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskSchedules), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskSchedules")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskSchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#schedule LogAnalyticsNamespaceScheduledTask#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskSchedulesSchedule\"},\"kind\":\"array\"}}]}}")]
            public object Schedule
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
