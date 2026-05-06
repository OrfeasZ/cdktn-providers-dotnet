using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetails")]
    public class AnalyticsAnalyticsInstanceNetworkEndpointDetails : oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_endpoint_type AnalyticsAnalyticsInstance#network_endpoint_type}.</summary>
        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkEndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_security_group_ids AnalyticsAnalyticsInstance#network_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NetworkSecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#subnet_id AnalyticsAnalyticsInstance#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#vcn_id AnalyticsAnalyticsInstance#vcn_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcnId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_ips AnalyticsAnalyticsInstance#whitelisted_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WhitelistedIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_services AnalyticsAnalyticsInstance#whitelisted_services}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "whitelistedServices", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WhitelistedServices
        {
            get;
            set;
        }

        private object? _whitelistedVcns;

        /// <summary>whitelisted_vcns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_vcns AnalyticsAnalyticsInstance#whitelisted_vcns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "whitelistedVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WhitelistedVcns
        {
            get => _whitelistedVcns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _whitelistedVcns = value;
            }
        }
    }
}
