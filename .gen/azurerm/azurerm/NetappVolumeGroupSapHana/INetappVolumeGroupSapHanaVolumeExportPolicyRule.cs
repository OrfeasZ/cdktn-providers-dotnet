using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupSapHana
{
    [JsiiInterface(nativeType: typeof(INetappVolumeGroupSapHanaVolumeExportPolicyRule), fullyQualifiedName: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeExportPolicyRule")]
    public interface INetappVolumeGroupSapHanaVolumeExportPolicyRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#allowed_clients NetappVolumeGroupSapHana#allowed_clients}.</summary>
        [JsiiProperty(name: "allowedClients", typeJson: "{\"primitive\":\"string\"}")]
        string AllowedClients
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#nfsv3_enabled NetappVolumeGroupSapHana#nfsv3_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Nfsv3Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#nfsv41_enabled NetappVolumeGroupSapHana#nfsv41_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "nfsv41Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Nfsv41Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#rule_index NetappVolumeGroupSapHana#rule_index}.</summary>
        [JsiiProperty(name: "ruleIndex", typeJson: "{\"primitive\":\"number\"}")]
        double RuleIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#root_access_enabled NetappVolumeGroupSapHana#root_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "rootAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RootAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#unix_read_only NetappVolumeGroupSapHana#unix_read_only}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "unixReadOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UnixReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#unix_read_write NetappVolumeGroupSapHana#unix_read_write}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "unixReadWrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UnixReadWrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeGroupSapHanaVolumeExportPolicyRule), fullyQualifiedName: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeExportPolicyRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeExportPolicyRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#allowed_clients NetappVolumeGroupSapHana#allowed_clients}.</summary>
            [JsiiProperty(name: "allowedClients", typeJson: "{\"primitive\":\"string\"}")]
            public string AllowedClients
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#nfsv3_enabled NetappVolumeGroupSapHana#nfsv3_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Nfsv3Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#nfsv41_enabled NetappVolumeGroupSapHana#nfsv41_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "nfsv41Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Nfsv41Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#rule_index NetappVolumeGroupSapHana#rule_index}.</summary>
            [JsiiProperty(name: "ruleIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#root_access_enabled NetappVolumeGroupSapHana#root_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RootAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#unix_read_only NetappVolumeGroupSapHana#unix_read_only}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unixReadOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UnixReadOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_sap_hana#unix_read_write NetappVolumeGroupSapHana#unix_read_write}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unixReadWrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UnixReadWrite
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
