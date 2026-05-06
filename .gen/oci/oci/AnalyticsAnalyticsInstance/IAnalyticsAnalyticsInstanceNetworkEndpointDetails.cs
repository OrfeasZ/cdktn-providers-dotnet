using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    [JsiiInterface(nativeType: typeof(IAnalyticsAnalyticsInstanceNetworkEndpointDetails), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetails")]
    public interface IAnalyticsAnalyticsInstanceNetworkEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_endpoint_type AnalyticsAnalyticsInstance#network_endpoint_type}.</summary>
        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkEndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_security_group_ids AnalyticsAnalyticsInstance#network_security_group_ids}.</summary>
        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NetworkSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#subnet_id AnalyticsAnalyticsInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#vcn_id AnalyticsAnalyticsInstance#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcnId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_ips AnalyticsAnalyticsInstance#whitelisted_ips}.</summary>
        [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WhitelistedIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_services AnalyticsAnalyticsInstance#whitelisted_services}.</summary>
        [JsiiProperty(name: "whitelistedServices", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WhitelistedServices
        {
            get
            {
                return null;
            }
        }

        /// <summary>whitelisted_vcns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_vcns AnalyticsAnalyticsInstance#whitelisted_vcns}
        /// </remarks>
        [JsiiProperty(name: "whitelistedVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WhitelistedVcns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalyticsAnalyticsInstanceNetworkEndpointDetails), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetails")]
        internal sealed class _Proxy : DeputyBase, oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_endpoint_type AnalyticsAnalyticsInstance#network_endpoint_type}.</summary>
            [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkEndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_security_group_ids AnalyticsAnalyticsInstance#network_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NetworkSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#subnet_id AnalyticsAnalyticsInstance#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#vcn_id AnalyticsAnalyticsInstance#vcn_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcnId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_ips AnalyticsAnalyticsInstance#whitelisted_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WhitelistedIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_services AnalyticsAnalyticsInstance#whitelisted_services}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "whitelistedServices", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WhitelistedServices
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>whitelisted_vcns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_vcns AnalyticsAnalyticsInstance#whitelisted_vcns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "whitelistedVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WhitelistedVcns
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
