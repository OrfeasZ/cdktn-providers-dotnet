using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIpv6AddressIpv6SubnetCidrPairDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIpv6AddressIpv6SubnetCidrPairDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIpv6AddressIpv6SubnetCidrPairDetails")]
        public virtual void ResetIpv6AddressIpv6SubnetCidrPairDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAssignIpv6Ip")]
        public virtual void ResetIsAssignIpv6Ip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ipv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetailsList\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetailsList Ipv6AddressIpv6SubnetCidrPairDetails
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressIpv6SubnetCidrPairDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ipv6AddressIpv6SubnetCidrPairDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAssignIpv6IpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAssignIpv6IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "isAssignIpv6Ip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAssignIpv6Ip
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

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets?>();
            set => SetInstanceProperty(value);
        }
    }
}
