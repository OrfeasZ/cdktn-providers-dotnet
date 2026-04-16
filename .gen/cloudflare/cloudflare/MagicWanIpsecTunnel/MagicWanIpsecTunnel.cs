using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_ipsec_tunnel cloudflare_magic_wan_ipsec_tunnel}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnel), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelConfig\"}}]")]
    public class MagicWanIpsecTunnel : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_ipsec_tunnel cloudflare_magic_wan_ipsec_tunnel} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MagicWanIpsecTunnel(Constructs.Construct scope, string id, cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MagicWanIpsecTunnel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MagicWanIpsecTunnel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MagicWanIpsecTunnel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MagicWanIpsecTunnel to import.</param>
        /// <param name="importFromId">The id of the existing MagicWanIpsecTunnel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MagicWanIpsecTunnel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MagicWanIpsecTunnel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_ipsec_tunnel#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MagicWanIpsecTunnel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MagicWanIpsecTunnel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBgp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgp\"}}]")]
        public virtual void PutBgp(cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomRemoteIdentities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentities\"}}]")]
        public virtual void PutCustomRemoteIdentities(cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelCustomRemoteIdentities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelCustomRemoteIdentities)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheck\"}}]")]
        public virtual void PutHealthCheck(cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticReturnRouting")]
        public virtual void ResetAutomaticReturnRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgp")]
        public virtual void ResetBgp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerEndpoint")]
        public virtual void ResetCustomerEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomRemoteIdentities")]
        public virtual void ResetCustomRemoteIdentities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInterfaceAddress6")]
        public virtual void ResetInterfaceAddress6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPsk")]
        public virtual void ResetPsk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplayProtection")]
        public virtual void ResetReplayProtection()
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
        = GetStaticProperty<string>(typeof(cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnel))!;

        [JsiiProperty(name: "allowNullCipher", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowNullCipher
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgpOutputReference\"}")]
        public virtual cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelBgpOutputReference Bgp
        {
            get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelBgpOutputReference>()!;
        }

        [JsiiProperty(name: "bgpStatus", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgpStatusOutputReference\"}")]
        public virtual cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelBgpStatusOutputReference BgpStatus
        {
            get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelBgpStatusOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customRemoteIdentities", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentitiesOutputReference\"}")]
        public virtual cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentitiesOutputReference CustomRemoteIdentities
        {
            get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentitiesOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckOutputReference\"}")]
        public virtual cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pskMetadata", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelPskMetadataOutputReference\"}")]
        public virtual cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelPskMetadataOutputReference PskMetadata
        {
            get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelPskMetadataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticReturnRoutingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutomaticReturnRoutingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgp\"}]}}", isOptional: true)]
        public virtual object? BgpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudflareEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudflareEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customRemoteIdentitiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentities\"}]}}", isOptional: true)]
        public virtual object? CustomRemoteIdentitiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheck\"}]}}", isOptional: true)]
        public virtual object? HealthCheckInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interfaceAddress6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InterfaceAddress6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interfaceAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InterfaceAddressInput
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
        [JsiiProperty(name: "pskInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PskInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replayProtectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReplayProtectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "automaticReturnRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AutomaticReturnRouting
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

        [JsiiProperty(name: "cloudflareEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudflareEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interfaceAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterfaceAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interfaceAddress6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterfaceAddress6
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

        [JsiiProperty(name: "psk", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Psk
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replayProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReplayProtection
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
    }
}
