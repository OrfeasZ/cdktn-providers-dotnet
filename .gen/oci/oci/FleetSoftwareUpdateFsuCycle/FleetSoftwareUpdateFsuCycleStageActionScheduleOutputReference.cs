using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiClass(nativeType: typeof(oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeToStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeToStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timeToStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeToStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionSchedule\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule? InternalValue
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
