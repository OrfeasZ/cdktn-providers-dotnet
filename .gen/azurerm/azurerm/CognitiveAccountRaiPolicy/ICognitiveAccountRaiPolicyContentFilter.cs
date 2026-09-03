using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccountRaiPolicy
{
    [JsiiInterface(nativeType: typeof(ICognitiveAccountRaiPolicyContentFilter), fullyQualifiedName: "azurerm.cognitiveAccountRaiPolicy.CognitiveAccountRaiPolicyContentFilter")]
    public interface ICognitiveAccountRaiPolicyContentFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#block_enabled CognitiveAccountRaiPolicy#block_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "blockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object BlockEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#filter_enabled CognitiveAccountRaiPolicy#filter_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "filterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object FilterEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#name CognitiveAccountRaiPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#source CognitiveAccountRaiPolicy#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#severity_threshold CognitiveAccountRaiPolicy#severity_threshold}.</summary>
        [JsiiProperty(name: "severityThreshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SeverityThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitiveAccountRaiPolicyContentFilter), fullyQualifiedName: "azurerm.cognitiveAccountRaiPolicy.CognitiveAccountRaiPolicyContentFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.CognitiveAccountRaiPolicy.ICognitiveAccountRaiPolicyContentFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#block_enabled CognitiveAccountRaiPolicy#block_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "blockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object BlockEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#filter_enabled CognitiveAccountRaiPolicy#filter_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "filterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object FilterEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#name CognitiveAccountRaiPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#source CognitiveAccountRaiPolicy#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_rai_policy#severity_threshold CognitiveAccountRaiPolicy#severity_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "severityThreshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SeverityThreshold
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
