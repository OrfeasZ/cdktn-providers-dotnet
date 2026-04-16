using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.IDataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.IDataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
