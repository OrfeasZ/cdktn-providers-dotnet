using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendsetA
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerBackendsetAHealthChecker), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthChecker")]
    public interface ILoadBalancerBackendsetAHealthChecker
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#protocol LoadBalancerBackendsetA#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#interval_ms LoadBalancerBackendsetA#interval_ms}.</summary>
        [JsiiProperty(name: "intervalMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#is_force_plain_text LoadBalancerBackendsetA#is_force_plain_text}.</summary>
        [JsiiProperty(name: "isForcePlainText", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForcePlainText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#port LoadBalancerBackendsetA#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#response_body_regex LoadBalancerBackendsetA#response_body_regex}.</summary>
        [JsiiProperty(name: "responseBodyRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseBodyRegex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#retries LoadBalancerBackendsetA#retries}.</summary>
        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Retries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#return_code LoadBalancerBackendsetA#return_code}.</summary>
        [JsiiProperty(name: "returnCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReturnCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#timeout_in_millis LoadBalancerBackendsetA#timeout_in_millis}.</summary>
        [JsiiProperty(name: "timeoutInMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInMillis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#url_path LoadBalancerBackendsetA#url_path}.</summary>
        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UrlPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerBackendsetAHealthChecker), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthChecker")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#protocol LoadBalancerBackendsetA#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#interval_ms LoadBalancerBackendsetA#interval_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intervalMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#is_force_plain_text LoadBalancerBackendsetA#is_force_plain_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForcePlainText", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForcePlainText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#port LoadBalancerBackendsetA#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#response_body_regex LoadBalancerBackendsetA#response_body_regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseBodyRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseBodyRegex
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#retries LoadBalancerBackendsetA#retries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Retries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#return_code LoadBalancerBackendsetA#return_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "returnCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReturnCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#timeout_in_millis LoadBalancerBackendsetA#timeout_in_millis}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInMillis
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#url_path LoadBalancerBackendsetA#url_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UrlPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
