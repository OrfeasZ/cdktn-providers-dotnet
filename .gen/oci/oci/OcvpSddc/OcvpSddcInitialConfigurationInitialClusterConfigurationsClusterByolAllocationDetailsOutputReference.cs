using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiClass(nativeType: typeof(oci.OcvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetailsOutputReference), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFirewallByolAllocationId")]
        public virtual void ResetFirewallByolAllocationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVsanByolAllocationId")]
        public virtual void ResetVsanByolAllocationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "firewallByolAllocationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirewallByolAllocationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vsanByolAllocationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VsanByolAllocationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallByolAllocationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsanByolAllocationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails\"}", isOptional: true)]
        public virtual oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
