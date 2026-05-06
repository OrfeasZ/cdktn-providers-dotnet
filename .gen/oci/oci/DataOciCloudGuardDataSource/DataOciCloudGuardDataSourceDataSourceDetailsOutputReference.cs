using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudGuardDataSource
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsOutputReference), fullyQualifiedName: "oci.dataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudGuardDataSourceDataSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudGuardDataSourceDataSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudGuardDataSourceDataSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudGuardDataSourceDataSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalEntitiesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalEntitiesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataSourceFeedProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceFeedProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "intervalInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loggingQueryDetails", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsLoggingQueryDetailsList\"}")]
        public virtual oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsLoggingQueryDetailsList LoggingQueryDetails
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsLoggingQueryDetailsList>()!;
        }

        [JsiiProperty(name: "loggingQueryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoggingQueryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryStartTime", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsQueryStartTimeList\"}")]
        public virtual oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsQueryStartTimeList QueryStartTime
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsQueryStartTimeList>()!;
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Regions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scheduledQueryScopeDetails", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetailsList\"}")]
        public virtual oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetailsList ScheduledQueryScopeDetails
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetailsList>()!;
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Threshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDataSource.DataOciCloudGuardDataSourceDataSourceDetails\"}", isOptional: true)]
        public virtual oci.DataOciCloudGuardDataSource.IDataOciCloudGuardDataSourceDataSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDataSource.IDataOciCloudGuardDataSourceDataSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
