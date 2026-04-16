using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxes
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference), fullyQualifiedName: "hcloud.dataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DayOfMonth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DayOfWeek
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Hour
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxSnapshots", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSnapshots
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Minute
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesSnapshotPlan\"}", isOptional: true)]
        public virtual hcloud.DataHcloudStorageBoxes.IDataHcloudStorageBoxesStorageBoxesSnapshotPlan? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxes.IDataHcloudStorageBoxesStorageBoxesSnapshotPlan?>();
            set => SetInstanceProperty(value);
        }
    }
}
