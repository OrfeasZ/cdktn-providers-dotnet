using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusOutputReference), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnServerConfigurationRadiusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpnServerConfigurationRadiusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpnServerConfigurationRadiusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnServerConfigurationRadiusOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate" />)[]</param>
        [JsiiMethod(name: "putClientRootCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientRootCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer" />)[]</param>
        [JsiiMethod(name: "putServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutServer(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate" />)[]</param>
        [JsiiMethod(name: "putServerRootCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutServerRootCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientRootCertificate")]
        public virtual void ResetClientRootCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServer")]
        public virtual void ResetServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerRootCertificate")]
        public virtual void ResetServerRootCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientRootCertificate", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificateList\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificateList ClientRootCertificate
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificateList>()!;
        }

        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerList\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusServerList Server
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusServerList>()!;
        }

        [JsiiProperty(name: "serverRootCertificate", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificateList\"}")]
        public virtual azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificateList ServerRootCertificate
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificateList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientRootCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientRootCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServerInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverRootCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServerRootCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadius\"}", isOptional: true)]
        public virtual azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius? InternalValue
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius?>();
            set => SetInstanceProperty(value);
        }
    }
}
