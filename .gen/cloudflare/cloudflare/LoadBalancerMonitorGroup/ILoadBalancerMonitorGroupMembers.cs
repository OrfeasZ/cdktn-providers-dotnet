using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerMonitorGroup
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerMonitorGroupMembers), fullyQualifiedName: "cloudflare.loadBalancerMonitorGroup.LoadBalancerMonitorGroupMembers")]
    public interface ILoadBalancerMonitorGroupMembers
    {
        /// <summary>Whether this monitor is enabled in the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#enabled LoadBalancerMonitorGroup#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#monitor_id LoadBalancerMonitorGroup#monitor_id}
        /// </remarks>
        [JsiiProperty(name: "monitorId", typeJson: "{\"primitive\":\"string\"}")]
        string MonitorId
        {
            get;
        }

        /// <summary>Whether this monitor is used for monitoring only (does not affect pool health).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#monitoring_only LoadBalancerMonitorGroup#monitoring_only}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "monitoringOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object MonitoringOnly
        {
            get;
        }

        /// <summary>Whether this monitor must be healthy for the pool to be considered healthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#must_be_healthy LoadBalancerMonitorGroup#must_be_healthy}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "mustBeHealthy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object MustBeHealthy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerMonitorGroupMembers), fullyQualifiedName: "cloudflare.loadBalancerMonitorGroup.LoadBalancerMonitorGroupMembers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerMonitorGroup.ILoadBalancerMonitorGroupMembers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether this monitor is enabled in the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#enabled LoadBalancerMonitorGroup#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#monitor_id LoadBalancerMonitorGroup#monitor_id}
            /// </remarks>
            [JsiiProperty(name: "monitorId", typeJson: "{\"primitive\":\"string\"}")]
            public string MonitorId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether this monitor is used for monitoring only (does not affect pool health).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#monitoring_only LoadBalancerMonitorGroup#monitoring_only}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "monitoringOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object MonitoringOnly
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Whether this monitor must be healthy for the pool to be considered healthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/load_balancer_monitor_group#must_be_healthy LoadBalancerMonitorGroup#must_be_healthy}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "mustBeHealthy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object MustBeHealthy
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
