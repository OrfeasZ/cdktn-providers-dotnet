using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolume.NetappVolumeCoolAccess")]
    public class NetappVolumeCoolAccess : azurerm.NetappVolume.INetappVolumeCoolAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume#coolness_period_in_days NetappVolume#coolness_period_in_days}.</summary>
        [JsiiProperty(name: "coolnessPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double CoolnessPeriodInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume#retrieval_policy NetappVolume#retrieval_policy}.</summary>
        [JsiiProperty(name: "retrievalPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string RetrievalPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume#tiering_policy NetappVolume#tiering_policy}.</summary>
        [JsiiProperty(name: "tieringPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string TieringPolicy
        {
            get;
            set;
        }
    }
}
