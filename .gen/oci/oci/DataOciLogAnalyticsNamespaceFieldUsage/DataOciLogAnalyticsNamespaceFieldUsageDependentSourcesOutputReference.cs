using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsNamespaceFieldUsage
{
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesOutputReference), fullyQualifiedName: "oci.dataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dependencies", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesList Dependencies
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesList>()!;
        }

        [JsiiProperty(name: "entityTypes", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesEntityTypesList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesEntityTypesList EntityTypes
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesEntityTypesList>()!;
        }

        [JsiiProperty(name: "isAutoAssociationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoAssociationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSystem", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSystem
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sourceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSources\"}", isOptional: true)]
        public virtual oci.DataOciLogAnalyticsNamespaceFieldUsage.IDataOciLogAnalyticsNamespaceFieldUsageDependentSources? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceFieldUsage.IDataOciLogAnalyticsNamespaceFieldUsageDependentSources?>();
            set => SetInstanceProperty(value);
        }
    }
}
