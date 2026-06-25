using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDifStack
{
    [JsiiClass(nativeType: typeof(oci.DataOciDifStack.DataOciDifStackAdbOutputReference), fullyQualifiedName: "oci.dataOciDifStack.DataOciDifStackAdbOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDifStackAdbOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDifStackAdbOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDifStackAdbOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDifStackAdbOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminPasswordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPasswordId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbCredentials", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackAdbDbCredentialsList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackAdbDbCredentialsList DbCredentials
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackAdbDbCredentialsList>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkload
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ecpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ecpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMtlsConnectionRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPublic", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPublic
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "toolsPublicAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolsPublicAccess
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackAdb\"}", isOptional: true)]
        public virtual oci.DataOciDifStack.IDataOciDifStackAdb? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDifStack.IDataOciDifStackAdb?>();
            set => SetInstanceProperty(value);
        }
    }
}
