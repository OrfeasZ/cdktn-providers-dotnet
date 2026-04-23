using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpnConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsVpnConnection.DataAwsVpnConnectionFilter")]
    public class DataAwsVpnConnectionFilter : aws.DataAwsVpnConnection.IDataAwsVpnConnectionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/vpn_connection#name DataAwsVpnConnection#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/vpn_connection#values DataAwsVpnConnection#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
