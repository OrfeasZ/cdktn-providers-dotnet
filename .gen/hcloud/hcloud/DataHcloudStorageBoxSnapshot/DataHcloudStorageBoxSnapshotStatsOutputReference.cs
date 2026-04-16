using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxSnapshot
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBoxSnapshot.DataHcloudStorageBoxSnapshotStatsOutputReference), fullyQualifiedName: "hcloud.dataHcloudStorageBoxSnapshot.DataHcloudStorageBoxSnapshotStatsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataHcloudStorageBoxSnapshotStatsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataHcloudStorageBoxSnapshotStatsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataHcloudStorageBoxSnapshotStatsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxSnapshotStatsOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxSnapshot.DataHcloudStorageBoxSnapshotStats\"}", isOptional: true)]
        public virtual hcloud.DataHcloudStorageBoxSnapshot.IDataHcloudStorageBoxSnapshotStats? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxSnapshot.IDataHcloudStorageBoxSnapshotStats?>();
            set => SetInstanceProperty(value);
        }
    }
}
