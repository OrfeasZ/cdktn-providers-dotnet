using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreInstancePoolPlacementConfigurationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreInstancePoolPlacementConfigurationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreInstancePoolPlacementConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolPlacementConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrimaryVnicSubnets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets\"}}]")]
        public virtual void PutPrimaryVnicSubnets(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondaryVnicSubnets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondaryVnicSubnets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFaultDomains")]
        public virtual void ResetFaultDomains()
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

        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference PrimaryVnicSubnets
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsOutputReference>()!;
        }

        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsList\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsList SecondaryVnicSubnets
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "faultDomainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FaultDomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primarySubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimarySubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryVnicSubnetsInput", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets? PrimaryVnicSubnetsInput
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryVnicSubnetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FaultDomains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimarySubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurations\"}]}}", isOptional: true)]
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
                        case oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurations cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurations).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
