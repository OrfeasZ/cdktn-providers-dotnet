using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSavingsplansOfferings
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsOfferingsOutputReference), fullyQualifiedName: "aws.dataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsOfferingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSavingsplansOfferingsOfferingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSavingsplansOfferingsOfferingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsSavingsplansOfferingsOfferingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSavingsplansOfferingsOfferingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "durationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "offeringId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfferingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentOption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProductTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"aws.dataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsOfferingsPropertiesList\"}")]
        public virtual aws.DataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsOfferingsPropertiesList Properties
        {
            get => GetInstanceProperty<aws.DataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsOfferingsPropertiesList>()!;
        }

        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsOfferings\"}", isOptional: true)]
        public virtual aws.DataAwsSavingsplansOfferings.IDataAwsSavingsplansOfferingsOfferings? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSavingsplansOfferings.IDataAwsSavingsplansOfferingsOfferings?>();
            set => SetInstanceProperty(value);
        }
    }
}
