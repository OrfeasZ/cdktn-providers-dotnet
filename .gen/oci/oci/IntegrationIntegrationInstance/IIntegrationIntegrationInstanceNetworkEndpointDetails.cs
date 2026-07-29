using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiInterface(nativeType: typeof(IIntegrationIntegrationInstanceNetworkEndpointDetails), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails")]
    public interface IIntegrationIntegrationInstanceNetworkEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#network_endpoint_type IntegrationIntegrationInstance#network_endpoint_type}.</summary>
        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkEndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#allowlisted_http_ips IntegrationIntegrationInstance#allowlisted_http_ips}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#allowlisted_http_vcns IntegrationIntegrationInstance#allowlisted_http_vcns}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns" />)[]</para>
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

        /// <summary>design_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#design_time IntegrationIntegrationInstance#design_time}
        /// </remarks>
        [JsiiProperty(name: "designTime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime? DesignTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#is_integration_vcn_allowlisted IntegrationIntegrationInstance#is_integration_vcn_allowlisted}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isIntegrationVcnAllowlisted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIntegrationVcnAllowlisted
        {
            get
            {
                return null;
            }
        }

        /// <summary>runtime block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#runtime IntegrationIntegrationInstance#runtime}
        /// </remarks>
        [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime? Runtime
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#network_endpoint_type IntegrationIntegrationInstance#network_endpoint_type}.</summary>
            [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkEndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#allowlisted_http_ips IntegrationIntegrationInstance#allowlisted_http_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowlistedHttpIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>allowlisted_http_vcns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#allowlisted_http_vcns IntegrationIntegrationInstance#allowlisted_http_vcns}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowlistedHttpVcns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>design_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#design_time IntegrationIntegrationInstance#design_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "designTime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime\"}", isOptional: true)]
            public oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime? DesignTime
            {
                get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#is_integration_vcn_allowlisted IntegrationIntegrationInstance#is_integration_vcn_allowlisted}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isIntegrationVcnAllowlisted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIntegrationVcnAllowlisted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>runtime block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/integration_integration_instance#runtime IntegrationIntegrationInstance#runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntime\"}", isOptional: true)]
            public oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime? Runtime
            {
                get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime?>();
            }
        }
    }
}
