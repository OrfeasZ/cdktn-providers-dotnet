using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicySessionControls")]
    public class ConditionalAccessPolicySessionControls : azuread.ConditionalAccessPolicy.IConditionalAccessPolicySessionControls
    {
        private object? _applicationEnforcedRestrictionsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#application_enforced_restrictions_enabled ConditionalAccessPolicy#application_enforced_restrictions_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationEnforcedRestrictionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ApplicationEnforcedRestrictionsEnabled
        {
            get => _applicationEnforcedRestrictionsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _applicationEnforcedRestrictionsEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#cloud_app_security_policy ConditionalAccessPolicy#cloud_app_security_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudAppSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudAppSecurityPolicy
        {
            get;
            set;
        }

        private object? _disableResilienceDefaults;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#disable_resilience_defaults ConditionalAccessPolicy#disable_resilience_defaults}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableResilienceDefaults", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableResilienceDefaults
        {
            get => _disableResilienceDefaults;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disableResilienceDefaults = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#persistent_browser_mode ConditionalAccessPolicy#persistent_browser_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "persistentBrowserMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistentBrowserMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency ConditionalAccessPolicy#sign_in_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signInFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SignInFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_authentication_type ConditionalAccessPolicy#sign_in_frequency_authentication_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signInFrequencyAuthenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignInFrequencyAuthenticationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_interval ConditionalAccessPolicy#sign_in_frequency_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signInFrequencyInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignInFrequencyInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_frequency_period ConditionalAccessPolicy#sign_in_frequency_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signInFrequencyPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignInFrequencyPeriod
        {
            get;
            set;
        }
    }
}
