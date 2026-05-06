using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiClass(nativeType: typeof(oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGoalVersion")]
        public virtual void ResetGoalVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "goalSoftwareImageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GoalSoftwareImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "goalTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GoalTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "goalVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GoalVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "goalSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GoalSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "goalType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GoalType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "goalVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GoalVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
