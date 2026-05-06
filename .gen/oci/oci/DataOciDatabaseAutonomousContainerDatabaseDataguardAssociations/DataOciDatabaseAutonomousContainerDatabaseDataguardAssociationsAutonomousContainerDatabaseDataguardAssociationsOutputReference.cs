using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applyLag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyLag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applyRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyRate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseDataguardAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseDataguardAssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FastStartFailOverLagLimitInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutomaticFailoverEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutomaticFailoverEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrateTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MigrateTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsPeerAutonomousContainerDatabaseBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsPeerAutonomousContainerDatabaseBackupConfigList PeerAutonomousContainerDatabaseBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociationsPeerAutonomousContainerDatabaseBackupConfigList>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousContainerDatabaseCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseDataguardAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousContainerDatabaseDataguardAssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousContainerDatabaseDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerCloudAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerDbUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerLifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerLifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StandbyMaintenanceBufferInDays
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "timeLastRoleChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRoleChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSynced", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSynced
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transportLag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportLag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociations\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.IDataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousContainerDatabaseDataguardAssociations.IDataOciDatabaseAutonomousContainerDatabaseDataguardAssociationsAutonomousContainerDatabaseDataguardAssociations?>();
            set => SetInstanceProperty(value);
        }
    }
}
