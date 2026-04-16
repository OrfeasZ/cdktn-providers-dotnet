using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareHyperdriveConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareHyperdriveConfig.DataCloudflareHyperdriveConfigOriginOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareHyperdriveConfig.DataCloudflareHyperdriveConfigOriginOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareHyperdriveConfigOriginOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareHyperdriveConfigOriginOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareHyperdriveConfigOriginOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareHyperdriveConfigOriginOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Database
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHyperdriveConfig.DataCloudflareHyperdriveConfigOrigin\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareHyperdriveConfig.IDataCloudflareHyperdriveConfigOrigin? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHyperdriveConfig.IDataCloudflareHyperdriveConfigOrigin?>();
            set => SetInstanceProperty(value);
        }
    }
}
