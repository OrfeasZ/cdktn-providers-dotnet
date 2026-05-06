using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiClass(nativeType: typeof(oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomerBgpAsn")]
        public virtual void ResetCustomerBgpAsn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerInterfaceIp")]
        public virtual void ResetCustomerInterfaceIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerInterfaceIpv6")]
        public virtual void ResetCustomerInterfaceIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracleInterfaceIp")]
        public virtual void ResetOracleInterfaceIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracleInterfaceIpv6")]
        public virtual void ResetOracleInterfaceIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bgpIpv6State", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpIpv6State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleBgpAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleBgpAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerBgpAsnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerBgpAsnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInterfaceIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInterfaceIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInterfaceIpv6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInterfaceIpv6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oracleInterfaceIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OracleInterfaceIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oracleInterfaceIpv6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OracleInterfaceIpv6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customerBgpAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerBgpAsn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerInterfaceIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerInterfaceIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerInterfaceIpv6
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oracleInterfaceIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleInterfaceIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oracleInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleInterfaceIpv6
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo? InternalValue
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
