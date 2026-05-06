using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmTracesScheduledQueries
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmTracesScheduledQueries.DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciApmTracesScheduledQueries.DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "opcDryRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcDryRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryInstances", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryInstances
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryMaximumRuntimeInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryMaximumRuntimeInSeconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryNextRunInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryNextRunInMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingConfiguration", typeJson: "{\"fqn\":\"oci.dataOciApmTracesScheduledQueries.DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsScheduledQueryProcessingConfigurationList\"}")]
        public virtual oci.DataOciApmTracesScheduledQueries.DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsScheduledQueryProcessingConfigurationList ScheduledQueryProcessingConfiguration
        {
            get => GetInstanceProperty<oci.DataOciApmTracesScheduledQueries.DataOciApmTracesScheduledQueriesScheduledQueryCollectionItemsScheduledQueryProcessingConfigurationList>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryProcessingSubType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryProcessingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryRetentionCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryRetentionCriteria
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryRetentionPeriodInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryRetentionPeriodInMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQuerySchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQuerySchedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryText
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmTracesScheduledQueries.DataOciApmTracesScheduledQueriesScheduledQueryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciApmTracesScheduledQueries.IDataOciApmTracesScheduledQueriesScheduledQueryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmTracesScheduledQueries.IDataOciApmTracesScheduledQueriesScheduledQueryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
