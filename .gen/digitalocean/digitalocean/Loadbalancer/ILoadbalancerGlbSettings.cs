using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiInterface(nativeType: typeof(ILoadbalancerGlbSettings), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerGlbSettings")]
    public interface ILoadbalancerGlbSettings
    {
        /// <summary>target port rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#target_port Loadbalancer#target_port}
        /// </remarks>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        double TargetPort
        {
            get;
        }

        /// <summary>target protocol rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#target_protocol Loadbalancer#target_protocol}
        /// </remarks>
        [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string TargetProtocol
        {
            get;
        }

        /// <summary>cdn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#cdn Loadbalancer#cdn}
        /// </remarks>
        [JsiiProperty(name: "cdn", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsCdn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn? Cdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>fail-over threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#failover_threshold Loadbalancer#failover_threshold}
        /// </remarks>
        [JsiiProperty(name: "failoverThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailoverThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>region priority map.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#region_priorities Loadbalancer#region_priorities}
        /// </remarks>
        [JsiiProperty(name: "regionPriorities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, double>? RegionPriorities
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadbalancerGlbSettings), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerGlbSettings")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Loadbalancer.ILoadbalancerGlbSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target port rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#target_port Loadbalancer#target_port}
            /// </remarks>
            [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>target protocol rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#target_protocol Loadbalancer#target_protocol}
            /// </remarks>
            [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cdn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#cdn Loadbalancer#cdn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cdn", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsCdn\"}", isOptional: true)]
            public digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn? Cdn
            {
                get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn?>();
            }

            /// <summary>fail-over threshold.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#failover_threshold Loadbalancer#failover_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailoverThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>region priority map.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#region_priorities Loadbalancer#region_priorities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionPriorities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, double>? RegionPriorities
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
            }
        }
    }
}
