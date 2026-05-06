using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResource
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceAliases), fullyQualifiedName: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliases")]
    public interface IStackMonitoringMonitoredResourceAliases
    {
        /// <summary>credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#credential StackMonitoringMonitoredResource#credential}
        /// </remarks>
        [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredential\"}")]
        oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential Credential
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#name StackMonitoringMonitoredResource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#source StackMonitoringMonitoredResource#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceAliases), fullyQualifiedName: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliases")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliases
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#credential StackMonitoringMonitoredResource#credential}
            /// </remarks>
            [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredential\"}")]
            public oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential Credential
            {
                get => GetInstanceProperty<oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#name StackMonitoringMonitoredResource#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#source StackMonitoringMonitoredResource#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
