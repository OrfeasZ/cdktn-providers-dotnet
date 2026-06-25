using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDifStack
{
    [JsiiClass(nativeType: typeof(oci.DataOciDifStack.DataOciDifStackGgcsOutputReference), fullyQualifiedName: "oci.dataOciDifStack.DataOciDifStackGgcsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDifStackGgcsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDifStackGgcsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDifStackGgcsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDifStackGgcsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGgcsConnectionsList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackGgcsConnectionsList Connections
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackGgcsConnectionsList>()!;
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

        [JsiiProperty(name: "sources", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGgcsSourcesList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackGgcsSourcesList Sources
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackGgcsSourcesList>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targets", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGgcsTargetsList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackGgcsTargetsList Targets
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackGgcsTargetsList>()!;
        }

        [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGgcsUsersList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackGgcsUsersList Users
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackGgcsUsersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGgcs\"}", isOptional: true)]
        public virtual oci.DataOciDifStack.IDataOciDifStackGgcs? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDifStack.IDataOciDifStackGgcs?>();
            set => SetInstanceProperty(value);
        }
    }
}
