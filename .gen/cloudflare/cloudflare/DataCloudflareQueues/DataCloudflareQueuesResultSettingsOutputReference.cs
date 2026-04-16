using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareQueues
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareQueues.DataCloudflareQueuesResultSettingsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareQueues.DataCloudflareQueuesResultSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareQueuesResultSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareQueuesResultSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareQueuesResultSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareQueuesResultSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deliveryDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeliveryDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deliveryPaused", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeliveryPaused
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "messageRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessageRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueues.DataCloudflareQueuesResultSettings\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareQueues.IDataCloudflareQueuesResultSettings? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueues.IDataCloudflareQueuesResultSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
