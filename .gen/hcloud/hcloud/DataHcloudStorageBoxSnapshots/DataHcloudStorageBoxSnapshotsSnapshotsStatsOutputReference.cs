using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxSnapshots
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsSnapshotsStatsOutputReference), fullyQualifiedName: "hcloud.dataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsSnapshotsStatsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataHcloudStorageBoxSnapshotsSnapshotsStatsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataHcloudStorageBoxSnapshotsSnapshotsStatsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataHcloudStorageBoxSnapshotsSnapshotsStatsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxSnapshotsSnapshotsStatsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sizeFilesystem", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeFilesystem
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsSnapshotsStats\"}", isOptional: true)]
        public virtual hcloud.DataHcloudStorageBoxSnapshots.IDataHcloudStorageBoxSnapshotsSnapshotsStats? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxSnapshots.IDataHcloudStorageBoxSnapshotsSnapshotsStats?>();
            set => SetInstanceProperty(value);
        }
    }
}
