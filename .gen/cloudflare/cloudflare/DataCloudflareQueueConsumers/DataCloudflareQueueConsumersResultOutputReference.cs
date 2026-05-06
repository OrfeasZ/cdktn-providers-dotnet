using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareQueueConsumers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareQueueConsumersResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareQueueConsumersResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareQueueConsumersResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareQueueConsumersResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "consumerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deadLetterQueue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeadLetterQueue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsOutputReference Settings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareQueueConsumers.IDataCloudflareQueueConsumersResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueueConsumers.IDataCloudflareQueueConsumersResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
