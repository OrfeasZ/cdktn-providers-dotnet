using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement
{
    [JsiiClass(nativeType: typeof(oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsOutputReference), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworkDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails\"}}]")]
        public virtual void PutNetworkDetails(oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdcsDomainId")]
        public virtual void ResetIdcsDomainId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseModel")]
        public virtual void ResetLicenseModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDetails")]
        public virtual void ResetNetworkDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsgIds")]
        public virtual void ResetNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetailsOutputReference\"}")]
        public virtual oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetailsOutputReference NetworkDetails
        {
            get => GetInstanceProperty<oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDetailsInput", typeJson: "{\"fqn\":\"oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails\"}", isOptional: true)]
        public virtual oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails? NetworkDetailsInput
        {
            get => GetInstanceProperty<oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "idcsDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails\"}", isOptional: true)]
        public virtual oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
