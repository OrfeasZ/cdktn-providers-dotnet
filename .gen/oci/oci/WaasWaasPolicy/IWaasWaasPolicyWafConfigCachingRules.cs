using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigCachingRules), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules")]
    public interface IWaasWaasPolicyWafConfigCachingRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#criteria WaasWaasPolicy#criteria}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRulesCriteria" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesCriteria\"},\"kind\":\"array\"}}]}}")]
        object Criteria
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#name WaasWaasPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#caching_duration WaasWaasPolicy#caching_duration}.</summary>
        [JsiiProperty(name: "cachingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CachingDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#client_caching_duration WaasWaasPolicy#client_caching_duration}.</summary>
        [JsiiProperty(name: "clientCachingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCachingDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#is_client_caching_enabled WaasWaasPolicy#is_client_caching_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isClientCachingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsClientCachingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#key WaasWaasPolicy#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigCachingRules), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#criteria WaasWaasPolicy#criteria}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRulesCriteria" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesCriteria\"},\"kind\":\"array\"}}]}}")]
            public object Criteria
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#name WaasWaasPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#caching_duration WaasWaasPolicy#caching_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cachingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CachingDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#client_caching_duration WaasWaasPolicy#client_caching_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientCachingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCachingDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#is_client_caching_enabled WaasWaasPolicy#is_client_caching_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isClientCachingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsClientCachingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/waas_waas_policy#key WaasWaasPolicy#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
