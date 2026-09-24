using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeCryptoAssessmentFindings
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compliance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compliance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "findingKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FindingKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isQuantumReadinessCheck", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsQuantumReadinessCheck
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "observedValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ObservedValue
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recommendedValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecommendedValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remediation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Remediation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shortRemediation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortRemediation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shortSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeCryptoAssessmentFindings.IDataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentFindings.IDataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
