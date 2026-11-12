using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolSets), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSets")]
    public interface ILoadBalancerPoolSets
    {
        /// <summary>Disable this specific pool set. It will no longer be evaluated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#disabled LoadBalancer#disabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A collection of fields used to directly respond to the client instead of routing to a pool.</summary>
        /// <remarks>
        /// When supplied on a rule, that rule stops further rule evaluation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#fixed_response LoadBalancer#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancer.ILoadBalancerPoolSetsFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines which requests a pool set applies to.</summary>
        /// <remarks>
        /// Set <c>topology</c> to match by location or <c>default: true</c> to match all requests; the two are mutually exclusive. A pool set with no <c>match</c> matches all requests.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#match LoadBalancer#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatch? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>A human-readable name for this pool set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#name LoadBalancer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The behavior a pool set applies when its `match` succeeds.</summary>
        /// <remarks>
        /// A strict subset of a rule's <c>overrides</c>: a pool set replaces the topology wholesale with a flat pool list (<c>pools</c>), so only the declarative pool-routing fields plus <c>fallback_pool</c> and <c>steering_policy</c> are settable. All fields are optional.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#overrides LoadBalancer#overrides}
        /// </remarks>
        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsOverrides\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancer.ILoadBalancerPoolSetsOverrides? Overrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolSets), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerPoolSets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Disable this specific pool set. It will no longer be evaluated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#disabled LoadBalancer#disabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Disabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A collection of fields used to directly respond to the client instead of routing to a pool.</summary>
            /// <remarks>
            /// When supplied on a rule, that rule stops further rule evaluation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#fixed_response LoadBalancer#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsFixedResponse\"}", isOptional: true)]
            public cloudflare.LoadBalancer.ILoadBalancerPoolSetsFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<cloudflare.LoadBalancer.ILoadBalancerPoolSetsFixedResponse?>();
            }

            /// <summary>Determines which requests a pool set applies to.</summary>
            /// <remarks>
            /// Set <c>topology</c> to match by location or <c>default: true</c> to match all requests; the two are mutually exclusive. A pool set with no <c>match</c> matches all requests.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#match LoadBalancer#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsMatch\"}", isOptional: true)]
            public cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatch? Match
            {
                get => GetInstanceProperty<cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatch?>();
            }

            /// <summary>A human-readable name for this pool set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#name LoadBalancer#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The behavior a pool set applies when its `match` succeeds.</summary>
            /// <remarks>
            /// A strict subset of a rule's <c>overrides</c>: a pool set replaces the topology wholesale with a flat pool list (<c>pools</c>), so only the declarative pool-routing fields plus <c>fallback_pool</c> and <c>steering_policy</c> are settable. All fields are optional.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#overrides LoadBalancer#overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsOverrides\"}", isOptional: true)]
            public cloudflare.LoadBalancer.ILoadBalancerPoolSetsOverrides? Overrides
            {
                get => GetInstanceProperty<cloudflare.LoadBalancer.ILoadBalancerPoolSetsOverrides?>();
            }
        }
    }
}
