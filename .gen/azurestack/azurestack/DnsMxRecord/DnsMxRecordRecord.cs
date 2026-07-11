using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DnsMxRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.dnsMxRecord.DnsMxRecordRecord")]
    public class DnsMxRecordRecord : azurestack.DnsMxRecord.IDnsMxRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/dns_mx_record#exchange DnsMxRecord#exchange}.</summary>
        [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
        public string Exchange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/dns_mx_record#preference DnsMxRecord#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
        public string Preference
        {
            get;
            set;
        }
    }
}
