using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aggregator", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataAggregatorList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataAggregatorList Aggregator
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataAggregatorList>()!;
        }

        [JsiiProperty(name: "aggregatorKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AggregatorKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "countStatistics", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataCountStatisticsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataCountStatisticsList CountStatistics
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadataCountStatisticsList>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdByName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedByName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identifierPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentifierPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infoFields", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap InfoFields
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isFavorite", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFavorite
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registryVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RegistryVersion
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedByName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedByName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedule.DataOciDataintegrationWorkspaceApplicationTaskScheduleMetadata\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.IDataOciDataintegrationWorkspaceApplicationTaskScheduleMetadata? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedule.IDataOciDataintegrationWorkspaceApplicationTaskScheduleMetadata?>();
            set => SetInstanceProperty(value);
        }
    }
}
