using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancerBackendSet.LoadBalancerBackendSetHealthChecker")]
    public class LoadBalancerBackendSetHealthChecker : oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#protocol LoadBalancerBackendSet#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#interval_ms LoadBalancerBackendSet#interval_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalMs
        {
            get;
            set;
        }

        private object? _isForcePlainText;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#is_force_plain_text LoadBalancerBackendSet#is_force_plain_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isForcePlainText", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsForcePlainText
        {
            get => _isForcePlainText;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isForcePlainText = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#port LoadBalancerBackendSet#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#response_body_regex LoadBalancerBackendSet#response_body_regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseBodyRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseBodyRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#retries LoadBalancerBackendSet#retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Retries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#return_code LoadBalancerBackendSet#return_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "returnCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReturnCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#timeout_in_millis LoadBalancerBackendSet#timeout_in_millis}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInMillis
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#url_path LoadBalancerBackendSet#url_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UrlPath
        {
            get;
            set;
        }
    }
}
