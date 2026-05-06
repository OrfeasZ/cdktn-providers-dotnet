using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiClass(nativeType: typeof(oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpeTrafficSelector")]
        public virtual void ResetCpeTrafficSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracleTrafficSelector")]
        public virtual void ResetOracleTrafficSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpeTrafficSelectorInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CpeTrafficSelectorInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oracleTrafficSelectorInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OracleTrafficSelectorInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "cpeTrafficSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CpeTrafficSelector
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oracleTrafficSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OracleTrafficSelector
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
