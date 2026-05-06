using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageCarbonEmission
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsOutputReference), fullyQualifiedName: "oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MeteringComputationUsageCarbonEmissionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MeteringComputationUsageCarbonEmissionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MeteringComputationUsageCarbonEmissionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationUsageCarbonEmissionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ad", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ad
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computedCarbonEmission", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputedCarbonEmission
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "emissionCalculationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmissionCalculationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emissionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmissionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Service
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skuPartNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuPartNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsTagsList\"}")]
        public virtual oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsTagsList Tags
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsTagsList>()!;
        }

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItems\"}", isOptional: true)]
        public virtual oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionItems? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
