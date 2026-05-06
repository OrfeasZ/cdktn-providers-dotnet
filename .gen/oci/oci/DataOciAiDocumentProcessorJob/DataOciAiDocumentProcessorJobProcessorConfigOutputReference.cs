using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiDocumentProcessorJob
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigOutputReference), fullyQualifiedName: "oci.dataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiDocumentProcessorJobProcessorConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiDocumentProcessorJobProcessorConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAiDocumentProcessorJobProcessorConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiDocumentProcessorJobProcessorConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigFeaturesList\"}")]
        public virtual oci.DataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigFeaturesList Features
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigFeaturesList>()!;
        }

        [JsiiProperty(name: "isZipOutputEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsZipOutputEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "normalizationFields", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigNormalizationFieldsList\"}")]
        public virtual oci.DataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigNormalizationFieldsList NormalizationFields
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfigNormalizationFieldsList>()!;
        }

        [JsiiProperty(name: "processorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentProcessorJob.DataOciAiDocumentProcessorJobProcessorConfig\"}", isOptional: true)]
        public virtual oci.DataOciAiDocumentProcessorJob.IDataOciAiDocumentProcessorJobProcessorConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentProcessorJob.IDataOciAiDocumentProcessorJobProcessorConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
