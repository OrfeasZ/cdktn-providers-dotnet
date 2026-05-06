using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreClusterNetwork
{
    [JsiiClass(nativeType: typeof(oci.CoreClusterNetwork.CoreClusterNetworkPlacementConfigurationOutputReference), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreClusterNetworkPlacementConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreClusterNetworkPlacementConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreClusterNetworkPlacementConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreClusterNetworkPlacementConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrimaryVnicSubnets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets\"}}]")]
        public virtual void PutPrimaryVnicSubnets(oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondaryVnicSubnets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondaryVnicSubnets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPlacementConstraint")]
        public virtual void ResetPlacementConstraint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimarySubnetId")]
        public virtual void ResetPrimarySubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryVnicSubnets")]
        public virtual void ResetPrimaryVnicSubnets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryVnicSubnets")]
        public virtual void ResetSecondaryVnicSubnets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsOutputReference\"}")]
        public virtual oci.CoreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsOutputReference PrimaryVnicSubnets
        {
            get => GetInstanceProperty<oci.CoreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsOutputReference>()!;
        }

        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnetsList\"}")]
        public virtual oci.CoreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnetsList SecondaryVnicSubnets
        {
            get => GetInstanceProperty<oci.CoreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnetsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlacementConstraintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primarySubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimarySubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryVnicSubnetsInput", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets\"}", isOptional: true)]
        public virtual oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets? PrimaryVnicSubnetsInput
        {
            get => GetInstanceProperty<oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryVnicSubnetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecondaryVnicSubnetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementConstraint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimarySubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfiguration\"}", isOptional: true)]
        public virtual oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
