using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostnames
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareCustomHostnamesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareCustomHostnamesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareCustomHostnamesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCustomHostnamesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap CustomMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "customOriginServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomOriginServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customOriginSni", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomOriginSni
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownershipVerification", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOwnershipVerificationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOwnershipVerificationOutputReference OwnershipVerification
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOwnershipVerificationOutputReference>()!;
        }

        [JsiiProperty(name: "ownershipVerificationHttp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOwnershipVerificationHttpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOwnershipVerificationHttpOutputReference OwnershipVerificationHttp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultOwnershipVerificationHttpOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslOutputReference Ssl
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "verificationErrors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VerificationErrors
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareCustomHostnames.IDataCloudflareCustomHostnamesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.IDataCloudflareCustomHostnamesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
