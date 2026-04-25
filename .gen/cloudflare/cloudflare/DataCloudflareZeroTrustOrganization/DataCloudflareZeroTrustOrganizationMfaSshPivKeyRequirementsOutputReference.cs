using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustOrganization
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustOrganization.DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirementsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustOrganization.DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirementsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirementsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "pinPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PinPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireFipsDevice", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireFipsDevice
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sshKeySize", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] SshKeySize
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "sshKeyType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshKeyType
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "touchPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TouchPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustOrganization.DataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirements\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustOrganization.IDataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirements? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustOrganization.IDataCloudflareZeroTrustOrganizationMfaSshPivKeyRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}
