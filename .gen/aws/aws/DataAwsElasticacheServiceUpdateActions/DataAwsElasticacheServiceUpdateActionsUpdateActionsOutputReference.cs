using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheServiceUpdateActions
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticacheServiceUpdateActions.DataAwsElasticacheServiceUpdateActionsUpdateActionsOutputReference), fullyQualifiedName: "aws.dataAwsElasticacheServiceUpdateActions.DataAwsElasticacheServiceUpdateActionsUpdateActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsElasticacheServiceUpdateActionsUpdateActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsElasticacheServiceUpdateActionsUpdateActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsElasticacheServiceUpdateActionsUpdateActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticacheServiceUpdateActionsUpdateActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cacheClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CacheClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedUpdateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedUpdateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recommendedApplyByDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecommendedApplyByDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUpdateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUpdateName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUpdateSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUpdateSeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUpdateStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUpdateStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUpdateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUpdateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateActionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateActionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsElasticacheServiceUpdateActions.DataAwsElasticacheServiceUpdateActionsUpdateActions\"}", isOptional: true)]
        public virtual aws.DataAwsElasticacheServiceUpdateActions.IDataAwsElasticacheServiceUpdateActionsUpdateActions? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsElasticacheServiceUpdateActions.IDataAwsElasticacheServiceUpdateActionsUpdateActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
