using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiOperationsInsightsWarehouseDownloadWarehouseWallet
{
    [JsiiInterface(nativeType: typeof(IOpsiOperationsInsightsWarehouseDownloadWarehouseWalletTimeouts), fullyQualifiedName: "oci.opsiOperationsInsightsWarehouseDownloadWarehouseWallet.OpsiOperationsInsightsWarehouseDownloadWarehouseWalletTimeouts")]
    public interface IOpsiOperationsInsightsWarehouseDownloadWarehouseWalletTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse_download_warehouse_wallet#create OpsiOperationsInsightsWarehouseDownloadWarehouseWallet#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse_download_warehouse_wallet#delete OpsiOperationsInsightsWarehouseDownloadWarehouseWallet#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse_download_warehouse_wallet#update OpsiOperationsInsightsWarehouseDownloadWarehouseWallet#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiOperationsInsightsWarehouseDownloadWarehouseWalletTimeouts), fullyQualifiedName: "oci.opsiOperationsInsightsWarehouseDownloadWarehouseWallet.OpsiOperationsInsightsWarehouseDownloadWarehouseWalletTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiOperationsInsightsWarehouseDownloadWarehouseWallet.IOpsiOperationsInsightsWarehouseDownloadWarehouseWalletTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse_download_warehouse_wallet#create OpsiOperationsInsightsWarehouseDownloadWarehouseWallet#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse_download_warehouse_wallet#delete OpsiOperationsInsightsWarehouseDownloadWarehouseWallet#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse_download_warehouse_wallet#update OpsiOperationsInsightsWarehouseDownloadWarehouseWallet#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
