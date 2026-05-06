using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiModel
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiModel.DataOciGenerativeAiModelModelMetricsOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiModel.DataOciGenerativeAiModelModelMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiModelModelMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiModelModelMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiModelModelMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiModelModelMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "finalAccuracy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FinalAccuracy
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "finalLoss", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FinalLoss
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "modelMetricsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelMetricsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiModel.DataOciGenerativeAiModelModelMetrics\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiModel.IDataOciGenerativeAiModelModelMetrics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiModel.IDataOciGenerativeAiModelModelMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
