using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVpnServerConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVpnServerConfiguration.DataAzurermVpnServerConfigurationIpsecPolicyOutputReference), fullyQualifiedName: "azurerm.dataAzurermVpnServerConfiguration.DataAzurermVpnServerConfigurationIpsecPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermVpnServerConfigurationIpsecPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermVpnServerConfigurationIpsecPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVpnServerConfigurationIpsecPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVpnServerConfigurationIpsecPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DhGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ikeEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeEncryption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ikeIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeIntegrity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipsecEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecEncryption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipsecIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecIntegrity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PfsGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "saDataSizeKilobytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaDataSizeKilobytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "saLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaLifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermVpnServerConfiguration.DataAzurermVpnServerConfigurationIpsecPolicy\"}", isOptional: true)]
        public virtual azurerm.DataAzurermVpnServerConfiguration.IDataAzurermVpnServerConfigurationIpsecPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermVpnServerConfiguration.IDataAzurermVpnServerConfigurationIpsecPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
