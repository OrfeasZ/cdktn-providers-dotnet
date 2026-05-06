using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadbVmCluster
{
    [JsiiClass(nativeType: typeof(oci.DatabaseExadbVmCluster.DatabaseExadbVmClusterNodeConfigOutputReference), fullyQualifiedName: "oci.databaseExadbVmCluster.DatabaseExadbVmClusterNodeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseExadbVmClusterNodeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseExadbVmClusterNodeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseExadbVmClusterNodeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExadbVmClusterNodeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "memorySizeInGbsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbsPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "snapshotFileSystemStorageSizeGbsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotFileSystemStorageSizeGbsPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalFileSystemStorageSizeGbsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalFileSystemStorageSizeGbsPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledEcpuCountPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EnabledEcpuCountPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalEcpuCountPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalEcpuCountPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmFileSystemStorageSizeGbsPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VmFileSystemStorageSizeGbsPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "enabledEcpuCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EnabledEcpuCountPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalEcpuCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalEcpuCountPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmFileSystemStorageSizeGbsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VmFileSystemStorageSizeGbsPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseExadbVmCluster.DatabaseExadbVmClusterNodeConfig\"}", isOptional: true)]
        public virtual oci.DatabaseExadbVmCluster.IDatabaseExadbVmClusterNodeConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseExadbVmCluster.IDatabaseExadbVmClusterNodeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
