using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/function_app_flex_consumption azurerm_function_app_flex_consumption}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumption), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumption", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConfig\"}}]")]
    public class FunctionAppFlexConsumption : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/function_app_flex_consumption azurerm_function_app_flex_consumption} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FunctionAppFlexConsumption(Constructs.Construct scope, string id, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppFlexConsumption(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppFlexConsumption(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FunctionAppFlexConsumption resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FunctionAppFlexConsumption to import.</param>
        /// <param name="importFromId">The id of the existing FunctionAppFlexConsumption that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FunctionAppFlexConsumption to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FunctionAppFlexConsumption to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/function_app_flex_consumption#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FunctionAppFlexConsumption that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FunctionAppFlexConsumption to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumption), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady" />)[]</param>
        [JsiiMethod(name: "putAlwaysReady", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReady\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAlwaysReady(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings\"}}]")]
        public virtual void PutAuthSettings(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthSettingsV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2\"}}]")]
        public virtual void PutAuthSettingsV2(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString" />)[]</param>
        [JsiiMethod(name: "putConnectionString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConnectionString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnectionString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSiteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfig\"}}]")]
        public virtual void PutSiteConfig(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStickySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings\"}}]")]
        public virtual void PutStickySettings(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlwaysReady")]
        public virtual void ResetAlwaysReady()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppSettings")]
        public virtual void ResetAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthSettings")]
        public virtual void ResetAuthSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthSettingsV2")]
        public virtual void ResetAuthSettingsV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateEnabled")]
        public virtual void ResetClientCertificateEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateExclusionPaths")]
        public virtual void ResetClientCertificateExclusionPaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateMode")]
        public virtual void ResetClientCertificateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionString")]
        public virtual void ResetConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpConcurrency")]
        public virtual void ResetHttpConcurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpsOnly")]
        public virtual void ResetHttpsOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceMemoryInMb")]
        public virtual void ResetInstanceMemoryInMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumInstanceCount")]
        public virtual void ResetMaximumInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStickySettings")]
        public virtual void ResetStickySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccessKey")]
        public virtual void ResetStorageAccessKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageUserAssignedIdentityId")]
        public virtual void ResetStorageUserAssignedIdentityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualNetworkSubnetId")]
        public virtual void ResetVirtualNetworkSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebdeployPublishBasicAuthenticationEnabled")]
        public virtual void ResetWebdeployPublishBasicAuthenticationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZipDeployFile")]
        public virtual void ResetZipDeployFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumption))!;

        [JsiiProperty(name: "alwaysReady", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReadyList\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReadyList AlwaysReady
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReadyList>()!;
        }

        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsOutputReference AuthSettings
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2OutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2OutputReference AuthSettingsV2
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2OutputReference>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConnectionStringList\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionConnectionStringList>()!;
        }

        [JsiiProperty(name: "customDomainVerificationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainVerificationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostingEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostingEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionIdentityOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundIpAddresses
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddressList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundIpAddressList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "possibleOutboundIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PossibleOutboundIpAddresses
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "possibleOutboundIpAddressList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PossibleOutboundIpAddressList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigOutputReference SiteConfig
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigOutputReference>()!;
        }

        [JsiiProperty(name: "siteCredential", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteCredentialList\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteCredentialList SiteCredential
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteCredentialList>()!;
        }

        [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettingsOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionStickySettingsOutputReference StickySettings
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionStickySettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionTimeoutsOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alwaysReadyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReady\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AlwaysReadyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AppSettingsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSettingsInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings? AuthSettingsInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSettingsV2Input", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2? AuthSettingsV2Input
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ClientCertificateEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateExclusionPathsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateExclusionPathsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionStringInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "httpConcurrencyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpConcurrencyInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpsOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionIdentity\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceMemoryInMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceMemoryInMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServicePlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "siteConfigInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfig\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig? SiteConfigInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickySettingsInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings? StickySettingsInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccessKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccessKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAuthenticationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAuthenticationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageContainerEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageContainerEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageContainerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageContainerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageUserAssignedIdentityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageUserAssignedIdentityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualNetworkSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WebdeployPublishBasicAuthenticationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipDeployFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipDeployFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AppSettings
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ClientCertificateEnabled
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

        [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateExclusionPaths
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateMode
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

        [JsiiProperty(name: "httpConcurrency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpConcurrency
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object HttpsOnly
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceMemoryInMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceMemoryInMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PublicNetworkAccessEnabled
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeName
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

        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccessKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAuthenticationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageContainerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageContainerEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageContainerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageContainerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageUserAssignedIdentityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object WebdeployPublishBasicAuthenticationEnabled
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

        [JsiiProperty(name: "zipDeployFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipDeployFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
