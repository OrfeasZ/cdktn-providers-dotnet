using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiClass(nativeType: typeof(cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsOutputReference), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AccountDnsSettingsZoneDefaultsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AccountDnsSettingsZoneDefaultsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AccountDnsSettingsZoneDefaultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccountDnsSettingsZoneDefaultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInternalDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns\"}}]")]
        public virtual void PutInternalDns(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNameservers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers\"}}]")]
        public virtual void PutNameservers(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSoa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa\"}}]")]
        public virtual void PutSoa(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFlattenAllCnames")]
        public virtual void ResetFlattenAllCnames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFoundationDns")]
        public virtual void ResetFoundationDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternalDns")]
        public virtual void ResetInternalDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiProvider")]
        public virtual void ResetMultiProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameservers")]
        public virtual void ResetNameservers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsTtl")]
        public virtual void ResetNsTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryOverrides")]
        public virtual void ResetSecondaryOverrides()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoa")]
        public virtual void ResetSoa()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneMode")]
        public virtual void ResetZoneMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDnsOutputReference\"}")]
        public virtual cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDnsOutputReference InternalDns
        {
            get => GetInstanceProperty<cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDnsOutputReference>()!;
        }

        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameserversOutputReference\"}")]
        public virtual cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsNameserversOutputReference Nameservers
        {
            get => GetInstanceProperty<cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsNameserversOutputReference>()!;
        }

        [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoaOutputReference\"}")]
        public virtual cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsSoaOutputReference Soa
        {
            get => GetInstanceProperty<cloudflare.AccountDnsSettings.AccountDnsSettingsZoneDefaultsSoaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "flattenAllCnamesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FlattenAllCnamesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "foundationDnsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FoundationDnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalDnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns\"}]}}", isOptional: true)]
        public virtual object? InternalDnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiProviderInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MultiProviderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameserversInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers\"}]}}", isOptional: true)]
        public virtual object? NameserversInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NsTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryOverridesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SecondaryOverridesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "soaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa\"}]}}", isOptional: true)]
        public virtual object? SoaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object FlattenAllCnames
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

        [JsiiProperty(name: "foundationDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object FoundationDns
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

        [JsiiProperty(name: "multiProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object MultiProvider
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

        [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NsTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SecondaryOverrides
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

        [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaults\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaults cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaults).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
