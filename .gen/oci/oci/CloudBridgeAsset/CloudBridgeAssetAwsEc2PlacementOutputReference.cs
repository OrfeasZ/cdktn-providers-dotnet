using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2PlacementOutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2PlacementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudBridgeAssetAwsEc2PlacementOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudBridgeAssetAwsEc2PlacementOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudBridgeAssetAwsEc2PlacementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetAwsEc2PlacementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAffinity")]
        public virtual void ResetAffinity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupName")]
        public virtual void ResetGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostKey")]
        public virtual void ResetHostKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostResourceGroupArn")]
        public virtual void ResetHostResourceGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitionNumber")]
        public virtual void ResetPartitionNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpreadDomain")]
        public virtual void ResetSpreadDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenancy")]
        public virtual void ResetTenancy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "affinityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AffinityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostResourceGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostResourceGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartitionNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spreadDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpreadDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenancyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Affinity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostResourceGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostResourceGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartitionNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpreadDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement? InternalValue
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement?>();
            set => SetInstanceProperty(value);
        }
    }
}
