using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.networkLoadBalancerNetworkLoadBalancersBackendSetsUnified.NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnifiedHealthChecker")]
    public class NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnifiedHealthChecker : oci.NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified.INetworkLoadBalancerNetworkLoadBalancersBackendSetsUnifiedHealthChecker
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#protocol NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>dns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#dns NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#dns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"oci.networkLoadBalancerNetworkLoadBalancersBackendSetsUnified.NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnifiedHealthCheckerDns\"}", isOptional: true)]
        public oci.NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified.INetworkLoadBalancerNetworkLoadBalancersBackendSetsUnifiedHealthCheckerDns? Dns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#interval_in_millis NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#interval_in_millis}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalInMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalInMillis
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#port NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#request_data NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#request_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#response_body_regex NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#response_body_regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseBodyRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseBodyRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#response_data NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#response_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#retries NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Retries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#return_code NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#return_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "returnCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReturnCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#timeout_in_millis NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#timeout_in_millis}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInMillis
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancers_backend_sets_unified#url_path NetworkLoadBalancerNetworkLoadBalancersBackendSetsUnified#url_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UrlPath
        {
            get;
            set;
        }
    }
}
