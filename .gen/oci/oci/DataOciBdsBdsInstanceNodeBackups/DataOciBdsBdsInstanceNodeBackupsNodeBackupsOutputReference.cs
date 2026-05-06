using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstanceNodeBackups
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstanceNodeBackups.DataOciBdsBdsInstanceNodeBackupsNodeBackupsOutputReference), fullyQualifiedName: "oci.dataOciBdsBdsInstanceNodeBackups.DataOciBdsBdsInstanceNodeBackupsNodeBackupsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsBdsInstanceNodeBackupsNodeBackupsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsBdsInstanceNodeBackupsNodeBackupsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsBdsInstanceNodeBackupsNodeBackupsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceNodeBackupsNodeBackupsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupTriggerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupTriggerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeBackupConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeBackupConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeHostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeHostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceNodeBackups.DataOciBdsBdsInstanceNodeBackupsNodeBackups\"}", isOptional: true)]
        public virtual oci.DataOciBdsBdsInstanceNodeBackups.IDataOciBdsBdsInstanceNodeBackupsNodeBackups? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceNodeBackups.IDataOciBdsBdsInstanceNodeBackupsNodeBackups?>();
            set => SetInstanceProperty(value);
        }
    }
}
