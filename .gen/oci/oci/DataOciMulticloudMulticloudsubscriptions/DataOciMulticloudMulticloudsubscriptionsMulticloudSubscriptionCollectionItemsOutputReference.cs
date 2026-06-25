using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudMulticloudsubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciMulticloudMulticloudsubscriptions.DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciMulticloudMulticloudsubscriptions.DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveCommitment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "classicSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClassicSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cspAdditionalProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap CspAdditionalProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerCloudAccountIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerCloudAccountIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerCloudTenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerCloudTenantIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentPlan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentPlan
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLinkedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLinkedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMulticloudMulticloudsubscriptions.DataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciMulticloudMulticloudsubscriptions.IDataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMulticloudMulticloudsubscriptions.IDataOciMulticloudMulticloudsubscriptionsMulticloudSubscriptionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
