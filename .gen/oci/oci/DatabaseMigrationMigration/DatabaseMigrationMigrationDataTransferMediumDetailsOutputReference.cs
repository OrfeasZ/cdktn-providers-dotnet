using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsOutputReference), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseMigrationMigrationDataTransferMediumDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseMigrationMigrationDataTransferMediumDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseMigrationMigrationDataTransferMediumDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationMigrationDataTransferMediumDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putObjectStorageBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket\"}}]")]
        public virtual void PutObjectStorageBucket(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource\"}}]")]
        public virtual void PutSource(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget\"}}]")]
        public virtual void PutTarget(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessKeyId")]
        public virtual void ResetAccessKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStorageBucket")]
        public virtual void ResetObjectStorageBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretAccessKey")]
        public virtual void ResetSecretAccessKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharedStorageMountTargetId")]
        public virtual void ResetSharedStorageMountTargetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "objectStorageBucket", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucketOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucketOutputReference ObjectStorageBucket
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucketOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference Source
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTargetOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTargetOutputReference Target
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageBucketInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket? ObjectStorageBucketInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretAccessKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedStorageMountTargetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SharedStorageMountTargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource? SourceInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget? TargetInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretAccessKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sharedStorageMountTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedStorageMountTargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetails\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
