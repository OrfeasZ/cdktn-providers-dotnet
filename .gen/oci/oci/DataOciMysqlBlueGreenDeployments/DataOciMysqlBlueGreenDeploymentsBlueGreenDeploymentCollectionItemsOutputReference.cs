using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlBlueGreenDeployments
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "channelDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsChannelDetailsList\"}")]
        public virtual oci.DataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsChannelDetailsList ChannelDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsChannelDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deleteTargetDbSystemOnDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteTargetDbSystemOnDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationChannelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationChannelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "switchoverStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwitchoverStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "switchoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SwitchoverTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetDbSystemDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsTargetDbSystemDetailsList\"}")]
        public virtual oci.DataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsTargetDbSystemDetailsList TargetDbSystemDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItemsTargetDbSystemDetailsList>()!;
        }

        [JsiiProperty(name: "targetDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDbSystemId
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlBlueGreenDeployments.DataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciMysqlBlueGreenDeployments.IDataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlBlueGreenDeployments.IDataOciMysqlBlueGreenDeploymentsBlueGreenDeploymentCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
