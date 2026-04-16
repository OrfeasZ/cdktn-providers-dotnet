using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    [JsiiClass(nativeType: typeof(stripe.V2CoreEventDestination.V2CoreEventDestinationAmazonEventbridgeOutputReference), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridgeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2CoreEventDestinationAmazonEventbridgeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2CoreEventDestinationAmazonEventbridgeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2CoreEventDestinationAmazonEventbridgeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2CoreEventDestinationAmazonEventbridgeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "awsEventSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsEventSourceArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsEventSourceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsEventSourceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridge\"}", isOptional: true)]
        public virtual stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge? InternalValue
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge?>();
            set => SetInstanceProperty(value);
        }
    }
}
