using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Precursor
{
    [JsiiInterface(nativeType: typeof(IPrecursorEnforcementRules), fullyQualifiedName: "cloudflare.precursor.PrecursorEnforcementRules")]
    public interface IPrecursorEnforcementRules
    {
        /// <summary>The filter expression that determines which requests the rule matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#expression Precursor#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>The override mode Precursor applies to requests matching an enforcement rule. Unlike `default_mode`, this cannot be `off`. Available values: "min-friction", "max-security".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#mode Precursor#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>An informative description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#description Precursor#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the rule is active.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#enabled Precursor#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrecursorEnforcementRules), fullyQualifiedName: "cloudflare.precursor.PrecursorEnforcementRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Precursor.IPrecursorEnforcementRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The filter expression that determines which requests the rule matches.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#expression Precursor#expression}
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The override mode Precursor applies to requests matching an enforcement rule. Unlike `default_mode`, this cannot be `off`. Available values: "min-friction", "max-security".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#mode Precursor#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An informative description of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#description Precursor#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the rule is active.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/precursor#enabled Precursor#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
