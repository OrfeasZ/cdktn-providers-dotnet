using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2CustomDomain
{
    [JsiiClass(nativeType: typeof(cloudflare.R2CustomDomain.R2CustomDomainStatusOutputReference), fullyQualifiedName: "cloudflare.r2CustomDomain.R2CustomDomainStatusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class R2CustomDomainStatusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public R2CustomDomainStatusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected R2CustomDomainStatusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2CustomDomainStatusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ownership", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ownership
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ssl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.r2CustomDomain.R2CustomDomainStatus\"}", isOptional: true)]
        public virtual cloudflare.R2CustomDomain.IR2CustomDomainStatus? InternalValue
        {
            get => GetInstanceProperty<cloudflare.R2CustomDomain.IR2CustomDomainStatus?>();
            set => SetInstanceProperty(value);
        }
    }
}
