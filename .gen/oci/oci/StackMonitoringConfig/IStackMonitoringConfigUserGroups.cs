using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringConfig
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringConfigUserGroups), fullyQualifiedName: "oci.stackMonitoringConfig.StackMonitoringConfigUserGroups")]
    public interface IStackMonitoringConfigUserGroups
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#stack_monitoring_role StackMonitoringConfig#stack_monitoring_role}.</summary>
        [JsiiProperty(name: "stackMonitoringRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StackMonitoringRole
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringConfigUserGroups), fullyQualifiedName: "oci.stackMonitoringConfig.StackMonitoringConfigUserGroups")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringConfig.IStackMonitoringConfigUserGroups
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#stack_monitoring_role StackMonitoringConfig#stack_monitoring_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stackMonitoringRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StackMonitoringRole
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
