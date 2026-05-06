using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceType
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceTypeMetadata), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeMetadata")]
    public interface IStackMonitoringMonitoredResourceTypeMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#format StackMonitoringMonitoredResourceType#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#agent_properties StackMonitoringMonitoredResourceType#agent_properties}.</summary>
        [JsiiProperty(name: "agentProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AgentProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#required_properties StackMonitoringMonitoredResourceType#required_properties}.</summary>
        [JsiiProperty(name: "requiredProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RequiredProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>unique_property_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#unique_property_sets StackMonitoringMonitoredResourceType#unique_property_sets}
        /// </remarks>
        [JsiiProperty(name: "uniquePropertySets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeMetadataUniquePropertySets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UniquePropertySets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_properties_for_create StackMonitoringMonitoredResourceType#valid_properties_for_create}.</summary>
        [JsiiProperty(name: "validPropertiesForCreate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ValidPropertiesForCreate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_properties_for_update StackMonitoringMonitoredResourceType#valid_properties_for_update}.</summary>
        [JsiiProperty(name: "validPropertiesForUpdate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ValidPropertiesForUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_property_values StackMonitoringMonitoredResourceType#valid_property_values}.</summary>
        [JsiiProperty(name: "validPropertyValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? ValidPropertyValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_sub_resource_types StackMonitoringMonitoredResourceType#valid_sub_resource_types}.</summary>
        [JsiiProperty(name: "validSubResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ValidSubResourceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceTypeMetadata), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeMetadata")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResourceType.IStackMonitoringMonitoredResourceTypeMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#format StackMonitoringMonitoredResourceType#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#agent_properties StackMonitoringMonitoredResourceType#agent_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AgentProperties
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#required_properties StackMonitoringMonitoredResourceType#required_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requiredProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RequiredProperties
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>unique_property_sets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#unique_property_sets StackMonitoringMonitoredResourceType#unique_property_sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uniquePropertySets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeMetadataUniquePropertySets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UniquePropertySets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_properties_for_create StackMonitoringMonitoredResourceType#valid_properties_for_create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validPropertiesForCreate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ValidPropertiesForCreate
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_properties_for_update StackMonitoringMonitoredResourceType#valid_properties_for_update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validPropertiesForUpdate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ValidPropertiesForUpdate
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_property_values StackMonitoringMonitoredResourceType#valid_property_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validPropertyValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? ValidPropertyValues
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#valid_sub_resource_types StackMonitoringMonitoredResourceType#valid_sub_resource_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validSubResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ValidSubResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
