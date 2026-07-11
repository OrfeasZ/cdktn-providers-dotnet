using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackLbRule
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackLbRule.DataAzurestackLbRuleTimeouts")]
    public class DataAzurestackLbRuleTimeouts : azurestack.DataAzurestackLbRule.IDataAzurestackLbRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/lb_rule#read DataAzurestackLbRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
