using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    [JsiiInterface(nativeType: typeof(INetappVolumeCoolAccess), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeCoolAccess")]
    public interface INetappVolumeCoolAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume#coolness_period_in_days NetappVolume#coolness_period_in_days}.</summary>
        [JsiiProperty(name: "coolnessPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        double CoolnessPeriodInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume#retrieval_policy NetappVolume#retrieval_policy}.</summary>
        [JsiiProperty(name: "retrievalPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string RetrievalPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume#tiering_policy NetappVolume#tiering_policy}.</summary>
        [JsiiProperty(name: "tieringPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string TieringPolicy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeCoolAccess), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeCoolAccess")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolume.INetappVolumeCoolAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume#coolness_period_in_days NetappVolume#coolness_period_in_days}.</summary>
            [JsiiProperty(name: "coolnessPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double CoolnessPeriodInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume#retrieval_policy NetappVolume#retrieval_policy}.</summary>
            [JsiiProperty(name: "retrievalPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string RetrievalPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume#tiering_policy NetappVolume#tiering_policy}.</summary>
            [JsiiProperty(name: "tieringPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string TieringPolicy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
