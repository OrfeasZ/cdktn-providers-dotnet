using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingDns
{
    [JsiiClass(nativeType: typeof(cloudflare.EmailRoutingDns.EmailRoutingDnsResultOutputReference), fullyQualifiedName: "cloudflare.emailRoutingDns.EmailRoutingDnsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmailRoutingDnsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmailRoutingDnsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmailRoutingDnsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmailRoutingDnsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errors", typeJson: "{\"fqn\":\"cloudflare.emailRoutingDns.EmailRoutingDnsResultErrorsList\"}")]
        public virtual cloudflare.EmailRoutingDns.EmailRoutingDnsResultErrorsList Errors
        {
            get => GetInstanceProperty<cloudflare.EmailRoutingDns.EmailRoutingDnsResultErrorsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "record", typeJson: "{\"fqn\":\"cloudflare.emailRoutingDns.EmailRoutingDnsResultRecordList\"}")]
        public virtual cloudflare.EmailRoutingDns.EmailRoutingDnsResultRecordList Record
        {
            get => GetInstanceProperty<cloudflare.EmailRoutingDns.EmailRoutingDnsResultRecordList>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.emailRoutingDns.EmailRoutingDnsResult\"}", isOptional: true)]
        public virtual cloudflare.EmailRoutingDns.IEmailRoutingDnsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.EmailRoutingDns.IEmailRoutingDnsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
