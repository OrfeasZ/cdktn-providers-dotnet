using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGateConnection
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGateConnection.DataOciGoldenGateConnectionArtifactLocationOutputReference), fullyQualifiedName: "oci.dataOciGoldenGateConnection.DataOciGoldenGateConnectionArtifactLocationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGateConnectionArtifactLocationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGateConnectionArtifactLocationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGateConnectionArtifactLocationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGateConnectionArtifactLocationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeySecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnection.DataOciGoldenGateConnectionArtifactLocationConfigurationList\"}")]
        public virtual oci.DataOciGoldenGateConnection.DataOciGoldenGateConnectionArtifactLocationConfigurationList Configuration
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnection.DataOciGoldenGateConnectionArtifactLocationConfigurationList>()!;
        }

        [JsiiProperty(name: "endpointSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filesystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Filesystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shouldOverwriteExisting", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldOverwriteExisting
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnection.DataOciGoldenGateConnectionArtifactLocation\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGateConnection.IDataOciGoldenGateConnectionArtifactLocation? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnection.IDataOciGoldenGateConnectionArtifactLocation?>();
            set => SetInstanceProperty(value);
        }
    }
}
