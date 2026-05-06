using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiInterface(nativeType: typeof(IIntegrationIntegrationInstanceNetworkEndpointDetails), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails")]
    public interface IIntegrationIntegrationInstanceNetworkEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#network_endpoint_type IntegrationIntegrationInstance#network_endpoint_type}.</summary>
        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkEndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#allowlisted_http_ips IntegrationIntegrationInstance#allowlisted_http_ips}.</summary>
        [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowlistedHttpIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>allowlisted_http_vcns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#allowlisted_http_vcns IntegrationIntegrationInstance#allowlisted_http_vcns}
        /// </remarks>
        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowlistedHttpVcns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#is_integration_vcn_allowlisted IntegrationIntegrationInstance#is_integration_vcn_allowlisted}.</summary>
        [JsiiProperty(name: "isIntegrationVcnAllowlisted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIntegrationVcnAllowlisted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIntegrationIntegrationInstanceNetworkEndpointDetails), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails")]
        internal sealed class _Proxy : DeputyBase, oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#network_endpoint_type IntegrationIntegrationInstance#network_endpoint_type}.</summary>
            [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkEndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#allowlisted_http_ips IntegrationIntegrationInstance#allowlisted_http_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowlistedHttpIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>allowlisted_http_vcns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#allowlisted_http_vcns IntegrationIntegrationInstance#allowlisted_http_vcns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowlistedHttpVcns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#is_integration_vcn_allowlisted IntegrationIntegrationInstance#is_integration_vcn_allowlisted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIntegrationVcnAllowlisted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIntegrationVcnAllowlisted
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
