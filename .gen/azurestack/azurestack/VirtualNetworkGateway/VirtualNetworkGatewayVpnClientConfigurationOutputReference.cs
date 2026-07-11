using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    [JsiiClass(nativeType: typeof(azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationOutputReference), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualNetworkGatewayVpnClientConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualNetworkGatewayVpnClientConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualNetworkGatewayVpnClientConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGatewayVpnClientConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate" />)[]</param>
        [JsiiMethod(name: "putRevokedCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRevokedCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate" />)[]</param>
        [JsiiMethod(name: "putRootCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRootCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRadiusServerAddress")]
        public virtual void ResetRadiusServerAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRadiusServerSecret")]
        public virtual void ResetRadiusServerSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevokedCertificate")]
        public virtual void ResetRevokedCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootCertificate")]
        public virtual void ResetRootCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnClientProtocols")]
        public virtual void ResetVpnClientProtocols()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "revokedCertificate", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificateList\"}")]
        public virtual azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificateList RevokedCertificate
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificateList>()!;
        }

        [JsiiProperty(name: "rootCertificate", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificateList\"}")]
        public virtual azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificateList RootCertificate
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificateList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressSpaceInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AddressSpaceInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "radiusServerAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RadiusServerAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "radiusServerSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RadiusServerSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revokedCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RevokedCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RootCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnClientProtocolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpnClientProtocolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "addressSpace", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AddressSpace
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "radiusServerAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RadiusServerAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "radiusServerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RadiusServerSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnClientProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpnClientProtocols
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration\"}", isOptional: true)]
        public virtual azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
