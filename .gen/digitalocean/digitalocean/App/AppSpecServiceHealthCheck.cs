using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecServiceHealthCheck")]
    public class AppSpecServiceHealthCheck : digitalocean.App.IAppSpecServiceHealthCheck
    {
        /// <summary>The number of failed health checks before considered unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#failure_threshold App#failure_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>The route path used for the HTTP health check ping.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#http_path App#http_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpPath
        {
            get;
            set;
        }

        /// <summary>The number of seconds to wait before beginning health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#initial_delay_seconds App#initial_delay_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialDelaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialDelaySeconds
        {
            get;
            set;
        }

        /// <summary>The number of seconds to wait between health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#period_seconds App#period_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodSeconds
        {
            get;
            set;
        }

        /// <summary>The port on which the health check will be performed.</summary>
        /// <remarks>
        /// If not set, the health check will be performed on the component's http_port.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#port App#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>The number of successful health checks before considered healthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#success_threshold App#success_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "successThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuccessThreshold
        {
            get;
            set;
        }

        /// <summary>The number of seconds after which the check times out.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#timeout_seconds App#timeout_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
