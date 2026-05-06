using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlDbSystems
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsOutputReference), fullyQualifiedName: "oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlMysqlDbSystemsDbSystemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlMysqlDbSystemsDbSystemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlMysqlDbSystemsDbSystemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlDbSystemsDbSystemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsBackupPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsBackupPolicyList BackupPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsBackupPolicyList>()!;
        }

        [JsiiProperty(name: "channels", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsChannelsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsChannelsList Channels
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsChannelsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crashRecovery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrashRecovery
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentPlacement", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsCurrentPlacementList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsCurrentPlacementList CurrentPlacement
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsCurrentPlacementList>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsCustomerContactsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsCustomerContactsList>()!;
        }

        [JsiiProperty(name: "databaseManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorage", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsDataStorageList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsDataStorageList DataStorage
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsDataStorageList>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deletionPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsDeletionPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsDeletionPolicyList DeletionPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsDeletionPolicyList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptData", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsEncryptDataList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsEncryptDataList EncryptData
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsEncryptDataList>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsEndpointsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsEndpointsList>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "heatWaveCluster", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsHeatWaveClusterList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsHeatWaveClusterList HeatWaveCluster
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsHeatWaveClusterList>()!;
        }

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHeatWaveClusterAttached", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHeatWaveClusterAttached
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHighlyAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighlyAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenance", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsMaintenanceList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsMaintenanceList Maintenance
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsMaintenanceList>()!;
        }

        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pointInTimeRecoveryDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsPointInTimeRecoveryDetailsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsPointInTimeRecoveryDetailsList PointInTimeRecoveryDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsPointInTimeRecoveryDetailsList>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "portX", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PortX
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readEndpoint", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsReadEndpointList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsReadEndpointList ReadEndpoint
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsReadEndpointList>()!;
        }

        [JsiiProperty(name: "rest", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsRestList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsRestList Rest
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsRestList>()!;
        }

        [JsiiProperty(name: "secureConnections", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsSecureConnectionsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsSecureConnectionsList SecureConnections
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsSecureConnectionsList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shutdownType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShutdownType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsSourceList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystemsSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystems.DataOciMysqlMysqlDbSystemsDbSystems\"}", isOptional: true)]
        public virtual oci.DataOciMysqlMysqlDbSystems.IDataOciMysqlMysqlDbSystemsDbSystems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystems.IDataOciMysqlMysqlDbSystemsDbSystems?>();
            set => SetInstanceProperty(value);
        }
    }
}
