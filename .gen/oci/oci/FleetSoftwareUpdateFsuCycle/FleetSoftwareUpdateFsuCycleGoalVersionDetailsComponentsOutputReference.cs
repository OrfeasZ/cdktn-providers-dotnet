using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiClass(nativeType: typeof(oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsOutputReference), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGoalVersionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails\"}}]")]
        public virtual void PutGoalVersionDetails(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHomePolicy")]
        public virtual void ResetHomePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNewHomePrefix")]
        public virtual void ResetNewHomePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "goalVersionDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference GoalVersionDetails
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComponentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "goalVersionDetailsInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails? GoalVersionDetailsInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homePolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomePolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "newHomePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NewHomePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homePolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomePolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "newHomePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewHomePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents\"}]}}", isOptional: true)]
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
                        case oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
