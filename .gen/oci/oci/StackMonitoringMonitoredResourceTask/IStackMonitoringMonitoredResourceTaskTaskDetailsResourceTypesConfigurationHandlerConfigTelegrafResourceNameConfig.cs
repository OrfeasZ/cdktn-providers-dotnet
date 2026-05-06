using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig")]
    public interface IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#exclude_tags StackMonitoringMonitoredResourceTask#exclude_tags}.</summary>
        [JsiiProperty(name: "excludeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludeTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#include_tags StackMonitoringMonitoredResourceTask#include_tags}.</summary>
        [JsiiProperty(name: "includeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludeTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_use_tags_only StackMonitoringMonitoredResourceTask#is_use_tags_only}.</summary>
        [JsiiProperty(name: "isUseTagsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUseTagsOnly
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#exclude_tags StackMonitoringMonitoredResourceTask#exclude_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludeTags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#include_tags StackMonitoringMonitoredResourceTask#include_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludeTags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_use_tags_only StackMonitoringMonitoredResourceTask#is_use_tags_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isUseTagsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUseTagsOnly
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
