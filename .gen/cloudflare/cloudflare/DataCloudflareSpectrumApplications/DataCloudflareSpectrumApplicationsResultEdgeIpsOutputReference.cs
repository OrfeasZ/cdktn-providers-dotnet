using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSpectrumApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectivity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Connectivity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ips
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultEdgeIps\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareSpectrumApplications.IDataCloudflareSpectrumApplicationsResultEdgeIps? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareSpectrumApplications.IDataCloudflareSpectrumApplicationsResultEdgeIps?>();
            set => SetInstanceProperty(value);
        }
    }
}
