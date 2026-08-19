using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiHostedApplicationIams
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiHostedApplicationIams.DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfigOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiHostedApplicationIams.DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "maxReplica", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReplica
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minReplica", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinReplica
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetConcurrencyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetConcurrencyThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetCpuThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCpuThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetMemoryThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetMemoryThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetRpsThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetRpsThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplicationIams.DataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfig\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiHostedApplicationIams.IDataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplicationIams.IDataOciGenerativeAiHostedApplicationIamsHostedApplicationCollectionItemsScalingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
