using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiClass(nativeType: typeof(azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsOutputReference), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionAppFlexConsumptionAuthSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionAppFlexConsumptionAuthSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FunctionAppFlexConsumptionAuthSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppFlexConsumptionAuthSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFacebook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebook\"}}]")]
        public virtual void PutFacebook(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithub\"}}]")]
        public virtual void PutGithub(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogle\"}}]")]
        public virtual void PutGoogle(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoft", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoft\"}}]")]
        public virtual void PutMicrosoft(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitter\"}}]")]
        public virtual void PutTwitter(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectory")]
        public virtual void ResetActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalLoginParameters")]
        public virtual void ResetAdditionalLoginParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedExternalRedirectUrls")]
        public virtual void ResetAllowedExternalRedirectUrls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultProvider")]
        public virtual void ResetDefaultProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFacebook")]
        public virtual void ResetFacebook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogle")]
        public virtual void ResetGoogle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoft")]
        public virtual void ResetMicrosoft()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeVersion")]
        public virtual void ResetRuntimeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenRefreshExtensionHours")]
        public virtual void ResetTokenRefreshExtensionHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenStoreEnabled")]
        public virtual void ResetTokenStoreEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwitter")]
        public virtual void ResetTwitter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnauthenticatedClientAction")]
        public virtual void ResetUnauthenticatedClientAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectoryOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebookOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebookOutputReference Facebook
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebookOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithubOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithubOutputReference Github
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithubOutputReference>()!;
        }

        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogleOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogleOutputReference Google
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogleOutputReference>()!;
        }

        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoftOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoftOutputReference Microsoft
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoftOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitterOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalLoginParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedExternalRedirectUrlsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedExternalRedirectUrlsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "facebookInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebook\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook? FacebookInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithub\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub? GithubInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogle\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle? GoogleInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoft\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft? MicrosoftInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenRefreshExtensionHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TokenRefreshExtensionHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenStoreEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TokenStoreEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitter\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter? TwitterInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedClientActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnauthenticatedClientActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalLoginParameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedExternalRedirectUrls
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
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

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TokenRefreshExtensionHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object TokenStoreEnabled
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

        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnauthenticatedClientAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
