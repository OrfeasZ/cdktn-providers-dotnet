using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneTracingRules
{
    [JsiiInterface(nativeType: typeof(IZoneTracingRulesRules), fullyQualifiedName: "cloudflare.zoneTracingRules.ZoneTracingRulesRules")]
    public interface IZoneTracingRulesRules
    {
        /// <summary>Available values: "set_trace_settings".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#action ZoneTracingRules#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#action_parameters ZoneTracingRules#action_parameters}.</summary>
        [JsiiProperty(name: "actionParameters", typeJson: "{\"fqn\":\"cloudflare.zoneTracingRules.ZoneTracingRulesRulesActionParameters\"}")]
        cloudflare.ZoneTracingRules.IZoneTracingRulesRulesActionParameters ActionParameters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#description ZoneTracingRules#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#enabled ZoneTracingRules#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>A Rules language expression that selects requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#expression ZoneTracingRules#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneTracingRulesRules), fullyQualifiedName: "cloudflare.zoneTracingRules.ZoneTracingRulesRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneTracingRules.IZoneTracingRulesRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "set_trace_settings".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#action ZoneTracingRules#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#action_parameters ZoneTracingRules#action_parameters}.</summary>
            [JsiiProperty(name: "actionParameters", typeJson: "{\"fqn\":\"cloudflare.zoneTracingRules.ZoneTracingRulesRulesActionParameters\"}")]
            public cloudflare.ZoneTracingRules.IZoneTracingRulesRulesActionParameters ActionParameters
            {
                get => GetInstanceProperty<cloudflare.ZoneTracingRules.IZoneTracingRulesRulesActionParameters>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#description ZoneTracingRules#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#enabled ZoneTracingRules#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A Rules language expression that selects requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#expression ZoneTracingRules#expression}
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
