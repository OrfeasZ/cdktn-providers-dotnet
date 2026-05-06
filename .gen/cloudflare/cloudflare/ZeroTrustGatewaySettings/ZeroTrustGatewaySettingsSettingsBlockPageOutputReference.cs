using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPageOutputReference), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustGatewaySettingsSettingsBlockPageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustGatewaySettingsSettingsBlockPageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustGatewaySettingsSettingsBlockPageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustGatewaySettingsSettingsBlockPageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBackgroundColor")]
        public virtual void ResetBackgroundColor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFooterText")]
        public virtual void ResetFooterText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeaderText")]
        public virtual void ResetHeaderText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeContext")]
        public virtual void ResetIncludeContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoPath")]
        public virtual void ResetLogoPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMailtoAddress")]
        public virtual void ResetMailtoAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMailtoSubject")]
        public virtual void ResetMailtoSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceAccount")]
        public virtual void ResetSourceAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuppressFooter")]
        public virtual void ResetSuppressFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetUri")]
        public virtual void ResetTargetUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "backgroundColorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackgroundColorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "footerTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FooterTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HeaderTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeContextInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludeContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mailtoAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MailtoAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mailtoSubjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MailtoSubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReadOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "suppressFooterInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SuppressFooterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackgroundColor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FooterText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeaderText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IncludeContext
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

        [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mailtoAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailtoAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mailtoSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailtoSubject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReadOnly
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

        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "suppressFooter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SuppressFooter
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

        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
