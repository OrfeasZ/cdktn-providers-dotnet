using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    [JsiiClass(nativeType: typeof(azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkSubnetOutputReference), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackHciLogicalNetworkSubnetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackHciLogicalNetworkSubnetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackHciLogicalNetworkSubnetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackHciLogicalNetworkSubnetOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool" />)[]</param>
        [JsiiMethod(name: "putIpPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIpPool(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute\"}}]")]
        public virtual void PutRoute(azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddressPrefix")]
        public virtual void ResetAddressPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpPool")]
        public virtual void ResetIpPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute")]
        public virtual void ResetRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVlanId")]
        public virtual void ResetVlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ipPool", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPoolList\"}")]
        public virtual azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPoolList IpPool
        {
            get => GetInstanceProperty<azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPoolList>()!;
        }

        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRouteOutputReference\"}")]
        public virtual azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkSubnetRouteOutputReference Route
        {
            get => GetInstanceProperty<azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkSubnetRouteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddressPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAllocationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAllocationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipPoolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IpPoolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeInput", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute\"}", isOptional: true)]
        public virtual azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute? RouteInput
        {
            get => GetInstanceProperty<azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vlanIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VlanIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipAllocationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAllocationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VlanId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnet\"}", isOptional: true)]
        public virtual azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnet? InternalValue
        {
            get => GetInstanceProperty<azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnet?>();
            set => SetInstanceProperty(value);
        }
    }
}
