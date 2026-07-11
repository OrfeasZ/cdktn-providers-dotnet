using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicySessionControls), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicySessionControls")]
    public interface IConditionalAccessPolicySessionControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#application_enforced_restrictions_enabled ConditionalAccessPolicy#application_enforced_restrictions_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "applicationEnforcedRestrictionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplicationEnforcedRestrictionsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#cloud_app_security_policy ConditionalAccessPolicy#cloud_app_security_policy}.</summary>
        [JsiiProperty(name: "cloudAppSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudAppSecurityPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#disable_resilience_defaults ConditionalAccessPolicy#disable_resilience_defaults}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disableResilienceDefaults", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableResilienceDefaults
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#persistent_browser_mode ConditionalAccessPolicy#persistent_browser_mode}.</summary>
        [JsiiProperty(name: "persistentBrowserMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistentBrowserMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency ConditionalAccessPolicy#sign_in_frequency}.</summary>
        [JsiiProperty(name: "signInFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SignInFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_authentication_type ConditionalAccessPolicy#sign_in_frequency_authentication_type}.</summary>
        [JsiiProperty(name: "signInFrequencyAuthenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignInFrequencyAuthenticationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_interval ConditionalAccessPolicy#sign_in_frequency_interval}.</summary>
        [JsiiProperty(name: "signInFrequencyInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignInFrequencyInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_period ConditionalAccessPolicy#sign_in_frequency_period}.</summary>
        [JsiiProperty(name: "signInFrequencyPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignInFrequencyPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicySessionControls), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicySessionControls")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicySessionControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#application_enforced_restrictions_enabled ConditionalAccessPolicy#application_enforced_restrictions_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationEnforcedRestrictionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ApplicationEnforcedRestrictionsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#cloud_app_security_policy ConditionalAccessPolicy#cloud_app_security_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudAppSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudAppSecurityPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#disable_resilience_defaults ConditionalAccessPolicy#disable_resilience_defaults}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableResilienceDefaults", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableResilienceDefaults
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#persistent_browser_mode ConditionalAccessPolicy#persistent_browser_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "persistentBrowserMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistentBrowserMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency ConditionalAccessPolicy#sign_in_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signInFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SignInFrequency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_authentication_type ConditionalAccessPolicy#sign_in_frequency_authentication_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signInFrequencyAuthenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignInFrequencyAuthenticationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_interval ConditionalAccessPolicy#sign_in_frequency_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signInFrequencyInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignInFrequencyInterval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_period ConditionalAccessPolicy#sign_in_frequency_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signInFrequencyPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignInFrequencyPeriod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
