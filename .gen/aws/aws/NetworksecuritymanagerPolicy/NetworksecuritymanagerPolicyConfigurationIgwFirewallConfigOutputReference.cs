using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    [JsiiClass(nativeType: typeof(aws.NetworksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigOutputReference), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride" />)[]</param>
        [JsiiMethod(name: "putSubnetConnectivityOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSubnetConnectivityOverride(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSubnetConnectivityOverride")]
        public virtual void ResetSubnetConnectivityOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "subnetConnectivityOverride", typeJson: "{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverrideList\"}")]
        public virtual aws.NetworksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverrideList SubnetConnectivityOverride
        {
            get => GetInstanceProperty<aws.NetworksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverrideList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSubnetConnectivityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSubnetConnectivityInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subnetConnectivityOverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SubnetConnectivityOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "defaultSubnetConnectivity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSubnetConnectivity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfig\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
