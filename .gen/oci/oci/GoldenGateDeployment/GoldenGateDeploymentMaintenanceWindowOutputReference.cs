using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiClass(nativeType: typeof(oci.GoldenGateDeployment.GoldenGateDeploymentMaintenanceWindowOutputReference), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GoldenGateDeploymentMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GoldenGateDeploymentMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GoldenGateDeploymentMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGateDeploymentMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Day
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentMaintenanceWindow\"}", isOptional: true)]
        public virtual oci.GoldenGateDeployment.IGoldenGateDeploymentMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<oci.GoldenGateDeployment.IGoldenGateDeploymentMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
