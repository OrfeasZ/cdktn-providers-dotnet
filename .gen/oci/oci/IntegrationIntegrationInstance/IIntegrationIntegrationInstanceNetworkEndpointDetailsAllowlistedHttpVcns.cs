using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiInterface(nativeType: typeof(IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns")]
    public interface IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#id IntegrationIntegrationInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#allowlisted_ips IntegrationIntegrationInstance#allowlisted_ips}.</summary>
        [JsiiProperty(name: "allowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowlistedIps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns")]
        internal sealed class _Proxy : DeputyBase, oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#id IntegrationIntegrationInstance#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#allowlisted_ips IntegrationIntegrationInstance#allowlisted_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowlistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowlistedIps
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
