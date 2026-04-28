using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiInterface(nativeType: typeof(ILoadbalancerFirewall), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerFirewall")]
    public interface ILoadbalancerFirewall
    {
        /// <summary>the rules for ALLOWING traffic to the LB (strings in the form: 'ip:1.2.3.4' or 'cidr:1.2.0.0/16').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#allow Loadbalancer#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>the rules for DENYING traffic to the LB (strings in the form: 'ip:1.2.3.4' or 'cidr:1.2.0.0/16').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#deny Loadbalancer#deny}
        /// </remarks>
        [JsiiProperty(name: "deny", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Deny
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadbalancerFirewall), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerFirewall")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Loadbalancer.ILoadbalancerFirewall
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>the rules for ALLOWING traffic to the LB (strings in the form: 'ip:1.2.3.4' or 'cidr:1.2.0.0/16').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#allow Loadbalancer#allow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Allow
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>the rules for DENYING traffic to the LB (strings in the form: 'ip:1.2.3.4' or 'cidr:1.2.0.0/16').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#deny Loadbalancer#deny}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deny", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Deny
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
