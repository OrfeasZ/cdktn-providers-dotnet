using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResource
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceAdditionalAliases), fullyQualifiedName: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAdditionalAliases")]
    public interface IStackMonitoringMonitoredResourceAdditionalAliases
    {
        /// <summary>credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#credential StackMonitoringMonitoredResource#credential}
        /// </remarks>
        [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAdditionalAliasesCredential\"}")]
        oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAdditionalAliasesCredential Credential
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

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceAdditionalAliases), fullyQualifiedName: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAdditionalAliases")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAdditionalAliases
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#credential StackMonitoringMonitoredResource#credential}
            /// </remarks>
            [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAdditionalAliasesCredential\"}")]
            public oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAdditionalAliasesCredential Credential
            {
                get => GetInstanceProperty<oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAdditionalAliasesCredential>()!;
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
