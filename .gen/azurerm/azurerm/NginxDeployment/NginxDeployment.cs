using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/nginx_deployment azurerm_nginx_deployment}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NginxDeployment.NginxDeployment), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentConfig\"}}]")]
    public class NginxDeployment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/nginx_deployment azurerm_nginx_deployment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NginxDeployment(Constructs.Construct scope, string id, azurerm.NginxDeployment.INginxDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NginxDeployment.INginxDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NginxDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NginxDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NginxDeployment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NginxDeployment to import.</param>
        /// <param name="importFromId">The id of the existing NginxDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NginxDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NginxDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/nginx_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NginxDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NginxDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.NginxDeployment.NginxDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile" />)[]</param>
        [JsiiMethod(name: "putAutoScaleProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentAutoScaleProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAutoScaleProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentFrontendPrivate" />)[]</param>
        [JsiiMethod(name: "putFrontendPrivate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPrivate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFrontendPrivate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.NginxDeployment.INginxDeploymentFrontendPrivate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentFrontendPrivate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentFrontendPrivate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrontendPublic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPublic\"}}]")]
        public virtual void PutFrontendPublic(azurerm.NginxDeployment.INginxDeploymentFrontendPublic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NginxDeployment.INginxDeploymentFrontendPublic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.NginxDeployment.INginxDeploymentIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NginxDeployment.INginxDeploymentIdentity)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentLoggingStorageAccount" />)[]</param>
        [JsiiMethod(name: "putLoggingStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentLoggingStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLoggingStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.NginxDeployment.INginxDeploymentLoggingStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentLoggingStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentLoggingStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentNetworkInterface" />)[]</param>
        [JsiiMethod(name: "putNetworkInterface", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentNetworkInterface\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterface(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.NginxDeployment.INginxDeploymentNetworkInterface[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentNetworkInterface).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NginxDeployment.INginxDeploymentNetworkInterface).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NginxDeployment.INginxDeploymentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NginxDeployment.INginxDeploymentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebApplicationFirewall", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewall\"}}]")]
        public virtual void PutWebApplicationFirewall(azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticUpgradeChannel")]
        public virtual void ResetAutomaticUpgradeChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoScaleProfile")]
        public virtual void ResetAutoScaleProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacity")]
        public virtual void ResetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiagnoseSupportEnabled")]
        public virtual void ResetDiagnoseSupportEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrontendPrivate")]
        public virtual void ResetFrontendPrivate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrontendPublic")]
        public virtual void ResetFrontendPublic()
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

        [JsiiMethod(name: "resetLoggingStorageAccount")]
        public virtual void ResetLoggingStorageAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedResourceGroup")]
        public virtual void ResetManagedResourceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterface")]
        public virtual void ResetNetworkInterface()
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

        [JsiiMethod(name: "resetWebApplicationFirewall")]
        public virtual void ResetWebApplicationFirewall()
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
        = GetStaticProperty<string>(typeof(azurerm.NginxDeployment.NginxDeployment))!;

        [JsiiProperty(name: "autoScaleProfile", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentAutoScaleProfileList\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentAutoScaleProfileList AutoScaleProfile
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentAutoScaleProfileList>()!;
        }

        [JsiiProperty(name: "dataplaneApiEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataplaneApiEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendPrivate", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPrivateList\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentFrontendPrivateList FrontendPrivate
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentFrontendPrivateList>()!;
        }

        [JsiiProperty(name: "frontendPublic", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPublicOutputReference\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentFrontendPublicOutputReference FrontendPublic
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentFrontendPublicOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentIdentityOutputReference\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingStorageAccount", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentLoggingStorageAccountList\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentLoggingStorageAccountList LoggingStorageAccount
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentLoggingStorageAccountList>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentNetworkInterfaceList\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "nginxVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NginxVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentTimeoutsOutputReference\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webApplicationFirewall", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewallOutputReference\"}")]
        public virtual azurerm.NginxDeployment.NginxDeploymentWebApplicationFirewallOutputReference WebApplicationFirewall
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.NginxDeploymentWebApplicationFirewallOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticUpgradeChannelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomaticUpgradeChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoScaleProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentAutoScaleProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AutoScaleProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diagnoseSupportEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DiagnoseSupportEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentFrontendPrivate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frontendPrivateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPrivate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FrontendPrivateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frontendPublicInput", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPublic\"}", isOptional: true)]
        public virtual azurerm.NginxDeployment.INginxDeploymentFrontendPublic? FrontendPublicInput
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentFrontendPublic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentIdentity\"}", isOptional: true)]
        public virtual azurerm.NginxDeployment.INginxDeploymentIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentLoggingStorageAccount" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingStorageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentLoggingStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LoggingStorageAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedResourceGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedResourceGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfaceInput
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
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NginxDeployment.INginxDeploymentTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webApplicationFirewallInput", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewall\"}", isOptional: true)]
        public virtual azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall? WebApplicationFirewallInput
        {
            get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall?>();
        }

        [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomaticUpgradeChannel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "diagnoseSupportEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DiagnoseSupportEnabled
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

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedResourceGroup
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
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
    }
}
