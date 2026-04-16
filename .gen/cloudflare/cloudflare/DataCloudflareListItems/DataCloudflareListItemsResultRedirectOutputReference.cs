using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareListItems
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareListItems.DataCloudflareListItemsResultRedirectOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareListItems.DataCloudflareListItemsResultRedirectOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareListItemsResultRedirectOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareListItemsResultRedirectOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareListItemsResultRedirectOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareListItemsResultRedirectOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeSubdomains
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "preservePathSuffix", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreservePathSuffix
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "preserveQueryString", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreserveQueryString
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StatusCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "subpathMatching", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SubpathMatching
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareListItems.DataCloudflareListItemsResultRedirect\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareListItems.IDataCloudflareListItemsResultRedirect? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareListItems.IDataCloudflareListItemsResultRedirect?>();
            set => SetInstanceProperty(value);
        }
    }
}
