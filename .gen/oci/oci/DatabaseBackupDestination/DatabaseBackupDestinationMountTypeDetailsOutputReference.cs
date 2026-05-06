using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseBackupDestination
{
    [JsiiClass(nativeType: typeof(oci.DatabaseBackupDestination.DatabaseBackupDestinationMountTypeDetailsOutputReference), fullyQualifiedName: "oci.databaseBackupDestination.DatabaseBackupDestinationMountTypeDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseBackupDestinationMountTypeDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseBackupDestinationMountTypeDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseBackupDestinationMountTypeDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseBackupDestinationMountTypeDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLocalMountPointPath")]
        public virtual void ResetLocalMountPointPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsServer")]
        public virtual void ResetNfsServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsServerExport")]
        public virtual void ResetNfsServerExport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "localMountPointPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalMountPointPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MountTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nfsServerExportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NfsServerExportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nfsServerInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NfsServerInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "localMountPointPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalMountPointPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MountType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nfsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NfsServer
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nfsServerExport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NfsServerExport
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseBackupDestination.DatabaseBackupDestinationMountTypeDetails\"}", isOptional: true)]
        public virtual oci.DatabaseBackupDestination.IDatabaseBackupDestinationMountTypeDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseBackupDestination.IDatabaseBackupDestinationMountTypeDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
