using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareHealthcheck
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareHealthcheck.DataCloudflareHealthcheckHttpConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareHealthcheck.DataCloudflareHealthcheckHttpConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareHealthcheckHttpConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareHealthcheckHttpConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareHealthcheckHttpConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareHealthcheckHttpConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowInsecure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowInsecure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "expectedBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExpectedCodes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "followRedirects", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FollowRedirects
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cdktn.StringListMap\"}")]
        public virtual Io.Cdktn.StringListMap Header
        {
            get => GetInstanceProperty<Io.Cdktn.StringListMap>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHealthcheck.DataCloudflareHealthcheckHttpConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareHealthcheck.IDataCloudflareHealthcheckHttpConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHealthcheck.IDataCloudflareHealthcheckHttpConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
