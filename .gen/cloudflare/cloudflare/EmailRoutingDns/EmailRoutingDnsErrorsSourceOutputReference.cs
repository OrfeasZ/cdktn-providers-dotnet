using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingDns
{
    [JsiiClass(nativeType: typeof(cloudflare.EmailRoutingDns.EmailRoutingDnsErrorsSourceOutputReference), fullyQualifiedName: "cloudflare.emailRoutingDns.EmailRoutingDnsErrorsSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmailRoutingDnsErrorsSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmailRoutingDnsErrorsSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmailRoutingDnsErrorsSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmailRoutingDnsErrorsSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "pointer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pointer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.emailRoutingDns.EmailRoutingDnsErrorsSource\"}", isOptional: true)]
        public virtual cloudflare.EmailRoutingDns.IEmailRoutingDnsErrorsSource? InternalValue
        {
            get => GetInstanceProperty<cloudflare.EmailRoutingDns.IEmailRoutingDnsErrorsSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
