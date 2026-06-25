using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCostadCostAnomalyEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciCostadCostAnomalyEvents.DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCostadCostAnomalyEvents.DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costAnomalyEventId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostAnomalyEventId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costAnomalyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostAnomalyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costImpact", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CostImpact
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "costMonitorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostMonitorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costMonitorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostMonitorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costMonitorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostMonitorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costVariancePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CostVariancePercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "feedbackResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeedbackResponse
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

        [JsiiProperty(name: "rootCauseDetail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootCauseDetail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetResourceFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAnomalyEventDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAnomalyEventDate
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCostadCostAnomalyEvents.DataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCostadCostAnomalyEvents.IDataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCostadCostAnomalyEvents.IDataOciCostadCostAnomalyEventsCostAnomalyEventCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
