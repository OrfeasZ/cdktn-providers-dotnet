using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOnesubscriptionSubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsOutputReference), fullyQualifiedName: "oci.dataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOnesubscriptionSubscriptionsSubscriptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOnesubscriptionSubscriptionsSubscriptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOnesubscriptionSubscriptionsSubscriptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionSubscriptionsSubscriptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currency", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsCurrencyList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsCurrencyList Currency
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsCurrencyList>()!;
        }

        [JsiiProperty(name: "holdReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HoldReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscribedServices", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsSubscribedServicesList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsSubscribedServicesList SubscribedServices
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptionsSubscribedServicesList>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeHoldReleaseEta", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeHoldReleaseEta
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscriptions.DataOciOnesubscriptionSubscriptionsSubscriptions\"}", isOptional: true)]
        public virtual oci.DataOciOnesubscriptionSubscriptions.IDataOciOnesubscriptionSubscriptionsSubscriptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscriptions.IDataOciOnesubscriptionSubscriptionsSubscriptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
