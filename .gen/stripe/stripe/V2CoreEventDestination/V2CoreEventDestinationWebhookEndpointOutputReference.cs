using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    [JsiiClass(nativeType: typeof(stripe.V2CoreEventDestination.V2CoreEventDestinationWebhookEndpointOutputReference), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpointOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2CoreEventDestinationWebhookEndpointOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2CoreEventDestinationWebhookEndpointOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2CoreEventDestinationWebhookEndpointOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2CoreEventDestinationWebhookEndpointOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "signingSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpoint\"}", isOptional: true)]
        public virtual stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint? InternalValue
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint?>();
            set => SetInstanceProperty(value);
        }
    }
}
