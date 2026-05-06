using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciVisualBuilderVbInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alternateCustomEndpoints", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsAlternateCustomEndpointsList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsAlternateCustomEndpointsList AlternateCustomEndpoints
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsAlternateCustomEndpointsList>()!;
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

        [JsiiProperty(name: "customEndpoint", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsCustomEndpointList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsCustomEndpointList CustomEndpoint
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsCustomEndpointList>()!;
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

        [JsiiProperty(name: "idcsOpenId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsOpenId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isVisualBuilderEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVisualBuilderEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managementNatGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementNatGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementVcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsNetworkEndpointDetailsList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsNetworkEndpointDetailsList NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItemsNetworkEndpointDetailsList>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serviceNatGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNatGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceVcnId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstances.DataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciVisualBuilderVbInstances.IDataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstances.IDataOciVisualBuilderVbInstancesVbInstanceSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
