using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentChecks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentChecksChecksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentChecksChecksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentChecksChecksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentChecksChecksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oneline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Oneline
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksPatchOperationsList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksPatchOperationsList>()!;
        }

        [JsiiProperty(name: "references", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksReferencesList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksReferencesList References
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecksReferencesList>()!;
        }

        [JsiiProperty(name: "remarks", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Remarks
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityAssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suggestedSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuggestedSeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentChecks.DataOciDataSafeSecurityAssessmentChecksChecks\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessmentChecks.IDataOciDataSafeSecurityAssessmentChecksChecks? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentChecks.IDataOciDataSafeSecurityAssessmentChecksChecks?>();
            set => SetInstanceProperty(value);
        }
    }
}
