using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxes
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesOutputReference), fullyQualifiedName: "hcloud.dataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudStorageBoxesStorageBoxesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudStorageBoxesStorageBoxesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataHcloudStorageBoxesStorageBoxesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxesStorageBoxesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessSettings", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesAccessSettingsOutputReference\"}")]
        public virtual hcloud.DataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesAccessSettingsOutputReference AccessSettings
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesAccessSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "deleteProtection", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteProtection
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Labels
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Server
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotPlan", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference\"}")]
        public virtual hcloud.DataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference SnapshotPlan
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxesSnapshotPlanOutputReference>()!;
        }

        [JsiiProperty(name: "storageBoxType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageBoxType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxes.DataHcloudStorageBoxesStorageBoxes\"}", isOptional: true)]
        public virtual hcloud.DataHcloudStorageBoxes.IDataHcloudStorageBoxesStorageBoxes? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxes.IDataHcloudStorageBoxesStorageBoxes?>();
            set => SetInstanceProperty(value);
        }
    }
}
