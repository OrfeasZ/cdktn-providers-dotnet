using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDeviceDefaultProfile
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDeviceDefaultProfile.DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworksOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDeviceDefaultProfile.DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Allowed
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Default
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceDefaultProfile.DataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworks\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceDefaultProfile.IDataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworks? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceDefaultProfile.IDataCloudflareZeroTrustDeviceDefaultProfileVirtualNetworks?>();
            set => SetInstanceProperty(value);
        }
    }
}
