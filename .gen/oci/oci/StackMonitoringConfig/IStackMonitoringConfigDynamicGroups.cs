using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringConfig
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringConfigDynamicGroups), fullyQualifiedName: "oci.stackMonitoringConfig.StackMonitoringConfigDynamicGroups")]
    public interface IStackMonitoringConfigDynamicGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#domain StackMonitoringConfig#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#name StackMonitoringConfig#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#stack_monitoring_assignment StackMonitoringConfig#stack_monitoring_assignment}.</summary>
        [JsiiProperty(name: "stackMonitoringAssignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StackMonitoringAssignment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringConfigDynamicGroups), fullyQualifiedName: "oci.stackMonitoringConfig.StackMonitoringConfigDynamicGroups")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringConfig.IStackMonitoringConfigDynamicGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#domain StackMonitoringConfig#domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#name StackMonitoringConfig#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#stack_monitoring_assignment StackMonitoringConfig#stack_monitoring_assignment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stackMonitoringAssignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StackMonitoringAssignment
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
