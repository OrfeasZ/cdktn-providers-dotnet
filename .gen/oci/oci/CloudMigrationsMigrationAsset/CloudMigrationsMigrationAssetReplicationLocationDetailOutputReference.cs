using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigrationAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudMigrationsMigrationAsset.CloudMigrationsMigrationAssetReplicationLocationDetailOutputReference), fullyQualifiedName: "oci.cloudMigrationsMigrationAsset.CloudMigrationsMigrationAssetReplicationLocationDetailOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudMigrationsMigrationAssetReplicationLocationDetailOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudMigrationsMigrationAssetReplicationLocationDetailOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudMigrationsMigrationAssetReplicationLocationDetailOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudMigrationsMigrationAssetReplicationLocationDetailOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationLocationType")]
        public virtual void ResetReplicationLocationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationLocationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationLocationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationLocationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationLocationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudMigrationsMigrationAsset.CloudMigrationsMigrationAssetReplicationLocationDetail\"}", isOptional: true)]
        public virtual oci.CloudMigrationsMigrationAsset.ICloudMigrationsMigrationAssetReplicationLocationDetail? InternalValue
        {
            get => GetInstanceProperty<oci.CloudMigrationsMigrationAsset.ICloudMigrationsMigrationAssetReplicationLocationDetail?>();
            set => SetInstanceProperty(value);
        }
    }
}
