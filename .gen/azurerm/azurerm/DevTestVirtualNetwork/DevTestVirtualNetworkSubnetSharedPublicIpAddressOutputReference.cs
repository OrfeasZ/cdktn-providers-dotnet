using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiClass(nativeType: typeof(azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevTestVirtualNetworkSubnetSharedPublicIpAddressOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts" />)[]</param>
        [JsiiMethod(name: "putAllowedPorts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowedPorts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowedPorts")]
        public virtual void ResetAllowedPorts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allowedPorts", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPortsList\"}")]
        public virtual azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPortsList AllowedPorts
        {
            get => GetInstanceProperty<azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPortsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedPortsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowedPortsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress\"}", isOptional: true)]
        public virtual azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress? InternalValue
        {
            get => GetInstanceProperty<azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress?>();
            set => SetInstanceProperty(value);
        }
    }
}
