using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseFirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseFirewall.DatabaseFirewallRule")]
    public class DatabaseFirewallRule : digitalocean.DatabaseFirewall.IDatabaseFirewallRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_firewall#type DatabaseFirewall#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_firewall#value DatabaseFirewall#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
