using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDifStacks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsOutputReference), fullyQualifiedName: "oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDifStacksStackCollectionItemsGgcsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDifStacksStackCollectionItemsGgcsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDifStacksStackCollectionItemsGgcsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDifStacksStackCollectionItemsGgcsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsConnectionsList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsConnectionsList Connections
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsConnectionsList>()!;
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OggVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sources", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsSourcesList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsSourcesList Sources
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsSourcesList>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targets", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsTargetsList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsTargetsList Targets
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsTargetsList>()!;
        }

        [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsUsersList\"}")]
        public virtual oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsUsersList Users
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcsUsersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDifStacks.DataOciDifStacksStackCollectionItemsGgcs\"}", isOptional: true)]
        public virtual oci.DataOciDifStacks.IDataOciDifStacksStackCollectionItemsGgcs? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDifStacks.IDataOciDifStacksStackCollectionItemsGgcs?>();
            set => SetInstanceProperty(value);
        }
    }
}
