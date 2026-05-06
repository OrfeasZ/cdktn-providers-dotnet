using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareList
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareList.DataCloudflareListItemsHostnameOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareList.DataCloudflareListItemsHostnameOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareListItemsHostnameOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareListItemsHostnameOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareListItemsHostnameOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareListItemsHostnameOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "excludeExactHostname", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExcludeExactHostname
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "urlHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareList.DataCloudflareListItemsHostname\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareList.IDataCloudflareListItemsHostname? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareList.IDataCloudflareListItemsHostname?>();
            set => SetInstanceProperty(value);
        }
    }
}
