using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiClass(nativeType: typeof(azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileOutputReference), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RedhatOpenshiftClusterNetworkProfileOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RedhatOpenshiftClusterNetworkProfileOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RedhatOpenshiftClusterNetworkProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedhatOpenshiftClusterNetworkProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoadBalancerProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfile\"}}]")]
        public virtual void PutLoadBalancerProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLoadBalancerProfile")]
        public virtual void ResetLoadBalancerProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundType")]
        public virtual void ResetOutboundType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreconfiguredNetworkSecurityGroupEnabled")]
        public virtual void ResetPreconfiguredNetworkSecurityGroupEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "loadBalancerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfileOutputReference LoadBalancerProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile? LoadBalancerProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PodCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preconfiguredNetworkSecurityGroupEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PreconfiguredNetworkSecurityGroupEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PodCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preconfiguredNetworkSecurityGroupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PreconfiguredNetworkSecurityGroupEnabled
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

        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
