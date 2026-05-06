using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiClass(nativeType: typeof(oci.WaasWaasPolicy.WaasWaasPolicyWafConfigOutputReference), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WaasWaasPolicyWafConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WaasWaasPolicyWafConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaasWaasPolicyWafConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaasWaasPolicyWafConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAccessRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddressRateLimiting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting\"}}]")]
        public virtual void PutAddressRateLimiting(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCachingRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCachingRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCaptchas", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCaptchas(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomProtectionRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomProtectionRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeviceFingerprintChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge\"}}]")]
        public virtual void PutDeviceFingerprintChallenge(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHumanInteractionChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallenge\"}}]")]
        public virtual void PutHumanInteractionChallenge(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJsChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge\"}}]")]
        public virtual void PutJsChallenge(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtectionSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings\"}}]")]
        public virtual void PutProtectionSettings(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWhitelists", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigWhitelists\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWhitelists(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigWhitelists[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigWhitelists).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigWhitelists).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessRules")]
        public virtual void ResetAccessRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddressRateLimiting")]
        public virtual void ResetAddressRateLimiting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCachingRules")]
        public virtual void ResetCachingRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptchas")]
        public virtual void ResetCaptchas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomProtectionRules")]
        public virtual void ResetCustomProtectionRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceFingerprintChallenge")]
        public virtual void ResetDeviceFingerprintChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHumanInteractionChallenge")]
        public virtual void ResetHumanInteractionChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJsChallenge")]
        public virtual void ResetJsChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrigin")]
        public virtual void ResetOrigin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginGroups")]
        public virtual void ResetOriginGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectionSettings")]
        public virtual void ResetProtectionSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWhitelists")]
        public virtual void ResetWhitelists()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessRules", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRulesList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigAccessRulesList AccessRules
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigAccessRulesList>()!;
        }

        [JsiiProperty(name: "addressRateLimiting", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimitingOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimitingOutputReference AddressRateLimiting
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimitingOutputReference>()!;
        }

        [JsiiProperty(name: "cachingRules", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesList CachingRules
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesList>()!;
        }

        [JsiiProperty(name: "captchas", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchasList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigCaptchasList Captchas
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigCaptchasList>()!;
        }

        [JsiiProperty(name: "customProtectionRules", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRulesList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRulesList CustomProtectionRules
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRulesList>()!;
        }

        [JsiiProperty(name: "deviceFingerprintChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeOutputReference DeviceFingerprintChallenge
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "humanInteractionChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeOutputReference HumanInteractionChallenge
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "jsChallenge", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeOutputReference JsChallenge
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "protectionSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettingsOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettingsOutputReference ProtectionSettings
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "whitelists", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigWhitelistsList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigWhitelistsList Whitelists
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigWhitelistsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AccessRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressRateLimitingInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting? AddressRateLimitingInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CachingRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CaptchasInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customProtectionRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomProtectionRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceFingerprintChallengeInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge? DeviceFingerprintChallengeInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanInteractionChallengeInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallenge\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge? HumanInteractionChallengeInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsChallengeInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge? JsChallengeInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OriginGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectionSettingsInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings? ProtectionSettingsInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "whitelistsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigWhitelists\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WhitelistsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Origin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OriginGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfig\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig? InternalValue
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
