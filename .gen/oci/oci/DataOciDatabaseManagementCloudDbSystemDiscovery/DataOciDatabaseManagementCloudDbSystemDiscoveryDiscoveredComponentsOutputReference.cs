using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementCloudDbSystemDiscovery
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adrHomeDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdrHomeDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "asmInstances", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsAsmInstancesList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsAsmInstancesList AsmInstances
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsAsmInstancesList>()!;
        }

        [JsiiProperty(name: "associatedComponents", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsAssociatedComponentsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsAssociatedComponentsList AssociatedComponents
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsAssociatedComponentsList>()!;
        }

        [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanEnableAllCurrentPdbs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterInstances", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsClusterInstancesList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsClusterInstancesList ClusterInstances
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsClusterInstancesList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsConnectorList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsConnectorList Connector
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsConnectorList>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "crsBaseDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrsBaseDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbaasId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbaasId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbEdition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbEdition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbInstances", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsDbInstancesList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsDbInstancesList DbInstances
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsDbInstancesList>()!;
        }

        [JsiiProperty(name: "dbNodeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbNodeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbPacks", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbPacks
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsEndpointsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsEndpointsList>()!;
        }

        [JsiiProperty(name: "gridHome", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GridHome
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "guid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Guid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "homeDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoEnablePluggableDatabase
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCluster", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCluster
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFlexCluster", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFlexCluster
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFlexEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFlexEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSelectedForMonitoring", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSelectedForMonitoring
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "listenerAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkConfigurations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsNetworkConfigurationsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsNetworkConfigurationsList NetworkConfigurations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsNetworkConfigurationsList>()!;
        }

        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocrFileLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OcrFileLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleHome", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleHome
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesList PluggableDatabases
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scanConfigurations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsScanConfigurationsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsScanConfigurationsList ScanConfigurations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsScanConfigurationsList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vipConfigurations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsVipConfigurationsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsVipConfigurationsList VipConfigurations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponentsVipConfigurationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscovery.DataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponents\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscovery.IDataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponents? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscovery.IDataOciDatabaseManagementCloudDbSystemDiscoveryDiscoveredComponents?>();
            set => SetInstanceProperty(value);
        }
    }
}
