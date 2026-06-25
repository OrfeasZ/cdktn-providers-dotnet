using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageOutputReference), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseToolsDatabaseToolsMcpServerStorageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseToolsDatabaseToolsMcpServerStorageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseToolsDatabaseToolsMcpServerStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsDatabaseToolsMcpServerStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucket\"}}]")]
        public virtual void PutBucket(oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucketOutputReference\"}")]
        public virtual oci.DatabaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucketOutputReference Bucket
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucketOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucket\"}", isOptional: true)]
        public virtual oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket? BucketInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorage\"}", isOptional: true)]
        public virtual oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
