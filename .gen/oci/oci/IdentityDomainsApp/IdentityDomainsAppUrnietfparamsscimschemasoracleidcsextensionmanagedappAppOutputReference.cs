using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBundleConfigurationProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBundleConfigurationProperties(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBundlePoolConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration\"}}]")]
        public virtual void PutBundlePoolConfiguration(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlatFileBundleConfigurationProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFlatFileBundleConfigurationProperties(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlatFileConnectorBundle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle\"}}]")]
        public virtual void PutFlatFileConnectorBundle(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreeLeggedOauthCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential\"}}]")]
        public virtual void PutThreeLeggedOauthCredential(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminConsentGranted")]
        public virtual void ResetAdminConsentGranted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBundleConfigurationProperties")]
        public virtual void ResetBundleConfigurationProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBundlePoolConfiguration")]
        public virtual void ResetBundlePoolConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnected")]
        public virtual void ResetConnected()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableAuthSyncNewUserNotification")]
        public virtual void ResetEnableAuthSyncNewUserNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableSync")]
        public virtual void ResetEnableSync()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableSyncSummaryReportNotification")]
        public virtual void ResetEnableSyncSummaryReportNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlatFileBundleConfigurationProperties")]
        public virtual void ResetFlatFileBundleConfigurationProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlatFileConnectorBundle")]
        public virtual void ResetFlatFileConnectorBundle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAuthoritative")]
        public virtual void ResetIsAuthoritative()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreeLeggedOauthCredential")]
        public virtual void ResetThreeLeggedOauthCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accountFormVisible", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountFormVisible
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bundleConfigurationProperties", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationPropertiesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationPropertiesList BundleConfigurationProperties
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationPropertiesList>()!;
        }

        [JsiiProperty(name: "bundlePoolConfiguration", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfigurationOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfigurationOutputReference BundlePoolConfiguration
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "canBeAuthoritative", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanBeAuthoritative
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connectorBundle", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppConnectorBundleList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppConnectorBundleList ConnectorBundle
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppConnectorBundleList>()!;
        }

        [JsiiProperty(name: "flatFileBundleConfigurationProperties", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationPropertiesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationPropertiesList FlatFileBundleConfigurationProperties
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationPropertiesList>()!;
        }

        [JsiiProperty(name: "flatFileConnectorBundle", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundleOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundleOutputReference FlatFileConnectorBundle
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundleOutputReference>()!;
        }

        [JsiiProperty(name: "identityBridges", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppIdentityBridgesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppIdentityBridgesList IdentityBridges
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppIdentityBridgesList>()!;
        }

        [JsiiProperty(name: "isDirectory", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDirectory
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOnPremiseApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOnPremiseApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSchemaCustomizationSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSchemaCustomizationSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSchemaDiscoverySupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSchemaDiscoverySupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isThreeLeggedOauthEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsThreeLeggedOauthEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTwoLeggedOauthEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTwoLeggedOauthEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "objectClasses", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppObjectClassesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppObjectClassesList ObjectClasses
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppObjectClassesList>()!;
        }

        [JsiiProperty(name: "syncConfigLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncConfigLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeLeggedOauthCredential", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredentialOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredentialOutputReference ThreeLeggedOauthCredential
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredentialOutputReference>()!;
        }

        [JsiiProperty(name: "threeLeggedOauthProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThreeLeggedOauthProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminConsentGrantedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AdminConsentGrantedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bundleConfigurationPropertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BundleConfigurationPropertiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bundlePoolConfigurationInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration? BundlePoolConfigurationInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ConnectedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableAuthSyncNewUserNotificationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAuthSyncNewUserNotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSyncInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableSyncInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSyncSummaryReportNotificationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableSyncSummaryReportNotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flatFileBundleConfigurationPropertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FlatFileBundleConfigurationPropertiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flatFileConnectorBundleInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle? FlatFileConnectorBundleInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAuthoritativeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAuthoritativeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threeLeggedOauthCredentialInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential? ThreeLeggedOauthCredentialInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential?>();
        }

        [JsiiProperty(name: "adminConsentGranted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AdminConsentGranted
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

        [JsiiProperty(name: "connected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Connected
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

        [JsiiProperty(name: "enableAuthSyncNewUserNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableAuthSyncNewUserNotification
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

        [JsiiProperty(name: "enableSync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableSync
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

        [JsiiProperty(name: "enableSyncSummaryReportNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableSyncSummaryReportNotification
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

        [JsiiProperty(name: "isAuthoritative", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAuthoritative
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
