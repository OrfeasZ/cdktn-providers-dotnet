using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIntegrationIntegrationInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesOutputReference), fullyQualifiedName: "oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIntegrationIntegrationInstancesIntegrationInstancesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIntegrationIntegrationInstancesIntegrationInstancesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIntegrationIntegrationInstancesIntegrationInstancesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIntegrationIntegrationInstancesIntegrationInstancesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alternateCustomEndpoints", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesAlternateCustomEndpointsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesAlternateCustomEndpointsList AlternateCustomEndpoints
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesAlternateCustomEndpointsList>()!;
        }

        [JsiiProperty(name: "attachments", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesAttachmentsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesAttachmentsList Attachments
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesAttachmentsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumptionModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumptionModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customEndpoint", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesCustomEndpointList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesCustomEndpointList CustomEndpoint
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesCustomEndpointList>()!;
        }

        [JsiiProperty(name: "dataRetentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataRetentionPeriod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "disasterRecoveryDetails", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesDisasterRecoveryDetailsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesDisasterRecoveryDetailsList DisasterRecoveryDetails
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesDisasterRecoveryDetailsList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableProcessAutomationTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EnableProcessAutomationTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extendDataRetentionTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExtendDataRetentionTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "failoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailoverTrigger
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "idcsAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsInfo", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesIdcsInfoList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesIdcsInfoList IdcsInfo
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesIdcsInfoList>()!;
        }

        [JsiiProperty(name: "instanceDesignTimeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDesignTimeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "integrationInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationInstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isByol", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsByol
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisasterRecoveryEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisasterRecoveryEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFileServerEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFileServerEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isVisualBuilderEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVisualBuilderEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "messagePacks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessagePacks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesNetworkEndpointDetailsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesNetworkEndpointDetailsList NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesNetworkEndpointDetailsList>()!;
        }

        [JsiiProperty(name: "privateEndpointOutboundConnection", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesPrivateEndpointOutboundConnectionList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesPrivateEndpointOutboundConnectionList PrivateEndpointOutboundConnection
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstancesPrivateEndpointOutboundConnectionList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateMessage
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstances.DataOciIntegrationIntegrationInstancesIntegrationInstances\"}", isOptional: true)]
        public virtual oci.DataOciIntegrationIntegrationInstances.IDataOciIntegrationIntegrationInstancesIntegrationInstances? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstances.IDataOciIntegrationIntegrationInstancesIntegrationInstances?>();
            set => SetInstanceProperty(value);
        }
    }
}
