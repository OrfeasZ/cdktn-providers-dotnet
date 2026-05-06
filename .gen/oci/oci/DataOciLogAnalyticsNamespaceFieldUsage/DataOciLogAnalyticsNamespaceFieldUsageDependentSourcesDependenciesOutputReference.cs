using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsNamespaceFieldUsage
{
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesOutputReference), fullyQualifiedName: "oci.dataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependenciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "referenceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceFieldUsage.DataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependencies\"}", isOptional: true)]
        public virtual oci.DataOciLogAnalyticsNamespaceFieldUsage.IDataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependencies? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceFieldUsage.IDataOciLogAnalyticsNamespaceFieldUsageDependentSourcesDependencies?>();
            set => SetInstanceProperty(value);
        }
    }
}
