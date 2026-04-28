using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.loadbalancer.LoadbalancerHealthcheck")]
    public class LoadbalancerHealthcheck : digitalocean.Loadbalancer.ILoadbalancerHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#port Loadbalancer#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#protocol Loadbalancer#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#check_interval_seconds Loadbalancer#check_interval_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CheckIntervalSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#healthy_threshold Loadbalancer#healthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#path Loadbalancer#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#response_timeout_seconds Loadbalancer#response_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ResponseTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#unhealthy_threshold Loadbalancer#unhealthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
