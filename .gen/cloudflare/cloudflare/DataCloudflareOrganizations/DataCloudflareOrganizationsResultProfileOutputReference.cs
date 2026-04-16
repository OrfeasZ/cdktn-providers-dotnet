using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultProfileOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareOrganizationsResultProfileOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareOrganizationsResultProfileOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareOrganizationsResultProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOrganizationsResultProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessPhone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalMetadata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultProfile\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResultProfile? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResultProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
