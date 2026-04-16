using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxTypes
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBoxTypes.DataHcloudStorageBoxTypesStorageBoxTypesOutputReference), fullyQualifiedName: "hcloud.dataHcloudStorageBoxTypes.DataHcloudStorageBoxTypesStorageBoxTypesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudStorageBoxTypesStorageBoxTypesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudStorageBoxTypesStorageBoxTypesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataHcloudStorageBoxTypesStorageBoxTypesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxTypesStorageBoxTypesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "automaticSnapshotLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutomaticSnapshotLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deprecationAnnounced", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeprecationAnnounced
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isDeprecated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDeprecated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "snapshotLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "subaccountsLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SubaccountsLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unavailableAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnavailableAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxTypes.DataHcloudStorageBoxTypesStorageBoxTypes\"}", isOptional: true)]
        public virtual hcloud.DataHcloudStorageBoxTypes.IDataHcloudStorageBoxTypesStorageBoxTypes? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxTypes.IDataHcloudStorageBoxTypesStorageBoxTypes?>();
            set => SetInstanceProperty(value);
        }
    }
}
