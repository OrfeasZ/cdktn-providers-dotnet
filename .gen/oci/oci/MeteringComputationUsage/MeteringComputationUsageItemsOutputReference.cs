using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsage
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationUsage.MeteringComputationUsageItemsOutputReference), fullyQualifiedName: "oci.meteringComputationUsage.MeteringComputationUsageItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MeteringComputationUsageItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MeteringComputationUsageItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MeteringComputationUsageItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationUsageItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ad", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ad
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributedCost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributedCost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributedUsage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributedUsage
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

        [JsiiProperty(name: "computedAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputedAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computedQuantity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputedQuantity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Discount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isForecast", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsForecast
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "listRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListRate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "overage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Overage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overagesFlag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OveragesFlag
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

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.meteringComputationUsage.MeteringComputationUsageItemsTagsList\"}")]
        public virtual oci.MeteringComputationUsage.MeteringComputationUsageItemsTagsList Tags
        {
            get => GetInstanceProperty<oci.MeteringComputationUsage.MeteringComputationUsageItemsTagsList>()!;
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

        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Unit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unitPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnitPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationUsage.MeteringComputationUsageItems\"}", isOptional: true)]
        public virtual oci.MeteringComputationUsage.IMeteringComputationUsageItems? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationUsage.IMeteringComputationUsageItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
