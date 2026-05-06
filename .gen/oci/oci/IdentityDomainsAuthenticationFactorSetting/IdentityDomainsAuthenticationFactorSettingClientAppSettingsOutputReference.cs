using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceProtectionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceProtectionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialLockoutPeriodInSecsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialLockoutPeriodInSecsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyPairLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? KeyPairLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lockoutEscalationPatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LockoutEscalationPatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxFailuresBeforeLockoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxFailuresBeforeLockoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxFailuresBeforeWarningInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxFailuresBeforeWarningInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxLockoutIntervalInSecsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxLockoutIntervalInSecsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minPinLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinPinLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyUpdateFreqInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PolicyUpdateFreqInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestSigningAlgoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestSigningAlgoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedSecretEncodingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SharedSecretEncodingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockAppForEachRequestEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UnlockAppForEachRequestEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockAppIntervalInSecsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UnlockAppIntervalInSecsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockOnAppForegroundEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UnlockOnAppForegroundEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockOnAppStartEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UnlockOnAppStartEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "deviceProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceProtectionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialLockoutPeriodInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialLockoutPeriodInSecs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyPairLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyPairLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lockoutEscalationPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockoutEscalationPattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxFailuresBeforeLockout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFailuresBeforeLockout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxFailuresBeforeWarning", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFailuresBeforeWarning
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxLockoutIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLockoutIntervalInSecs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minPinLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPinLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyUpdateFreqInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PolicyUpdateFreqInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestSigningAlgo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestSigningAlgo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sharedSecretEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedSecretEncoding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unlockAppForEachRequestEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object UnlockAppForEachRequestEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "unlockAppIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnlockAppIntervalInSecs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unlockOnAppForegroundEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object UnlockOnAppForegroundEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "unlockOnAppStartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object UnlockOnAppStartEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingClientAppSettings\"}", isOptional: true)]
        public virtual oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingClientAppSettings? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingClientAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
