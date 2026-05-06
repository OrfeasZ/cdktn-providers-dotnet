using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesOutputReference), fullyQualifiedName: "oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsBdsInstancesBdsInstancesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsBdsInstancesBdsInstancesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsBdsInstancesBdsInstancesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstancesBdsInstancesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bdsClusterVersionSummary", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesBdsClusterVersionSummaryList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesBdsClusterVersionSummaryList BdsClusterVersionSummary
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesBdsClusterVersionSummaryList>()!;
        }

        [JsiiProperty(name: "bootstrapScriptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapScriptUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudSqlDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesCloudSqlDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesCloudSqlDetailsList CloudSqlDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesCloudSqlDetailsList>()!;
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesClusterDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesClusterDetailsList ClusterDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesClusterDetailsList>()!;
        }

        [JsiiProperty(name: "clusterProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterProfile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeOnlyWorkerNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesComputeOnlyWorkerNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesComputeOnlyWorkerNodeList ComputeOnlyWorkerNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesComputeOnlyWorkerNodeList>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesEdgeNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesEdgeNodeList EdgeNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesEdgeNodeList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ignoreExistingNodesShape", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IgnoreExistingNodesShape
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isCloudSqlConfigured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCloudSqlConfigured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isForceRemoveEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsForceRemoveEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isForceStopJobs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsForceStopJobs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHighAvailability", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighAvailability
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isKafkaConfigured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsKafkaConfigured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSecure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSecure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kafkaBrokerNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesKafkaBrokerNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesKafkaBrokerNodeList KafkaBrokerNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesKafkaBrokerNodeList>()!;
        }

        [JsiiProperty(name: "kerberosRealmName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosRealmName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesMasterNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesMasterNodeList MasterNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesMasterNodeList>()!;
        }

        [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesNetworkConfigList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesNetworkConfigList NetworkConfig
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesNetworkConfigList>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesNodesList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesNodesList Nodes
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesNodesList>()!;
        }

        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfNodesRequiringMaintenanceReboot", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodesRequiringMaintenanceReboot
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "osPatchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsPatchVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "removeNode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoveNode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startClusterShapeConfigs", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesStartClusterShapeConfigsList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesStartClusterShapeConfigsList StartClusterShapeConfigs
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesStartClusterShapeConfigsList>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "utilNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesUtilNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesUtilNodeList UtilNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesUtilNodeList>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesWorkerNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesWorkerNodeList WorkerNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesWorkerNodeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstances\"}", isOptional: true)]
        public virtual oci.DataOciBdsBdsInstances.IDataOciBdsBdsInstancesBdsInstances? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.IDataOciBdsBdsInstancesBdsInstances?>();
            set => SetInstanceProperty(value);
        }
    }
}
