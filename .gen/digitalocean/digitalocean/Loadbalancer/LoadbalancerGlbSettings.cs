using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.loadbalancer.LoadbalancerGlbSettings")]
    public class LoadbalancerGlbSettings : digitalocean.Loadbalancer.ILoadbalancerGlbSettings
    {
        /// <summary>target port rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#target_port Loadbalancer#target_port}
        /// </remarks>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetPort
        {
            get;
            set;
        }

        /// <summary>target protocol rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#target_protocol Loadbalancer#target_protocol}
        /// </remarks>
        [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetProtocol
        {
            get;
            set;
        }

        /// <summary>cdn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#cdn Loadbalancer#cdn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cdn", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsCdn\"}", isOptional: true)]
        public digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn? Cdn
        {
            get;
            set;
        }

        /// <summary>fail-over threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#failover_threshold Loadbalancer#failover_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failoverThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailoverThreshold
        {
            get;
            set;
        }

        /// <summary>region priority map.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#region_priorities Loadbalancer#region_priorities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionPriorities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, double>? RegionPriorities
        {
            get;
            set;
        }
    }
}
