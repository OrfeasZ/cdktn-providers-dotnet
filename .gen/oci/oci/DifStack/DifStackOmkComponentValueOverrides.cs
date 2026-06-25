using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackOmkComponentValueOverrides")]
    public class DifStackOmkComponentValueOverrides : oci.DifStack.IDifStackOmkComponentValueOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#component_name DifStack#component_name}.</summary>
        [JsiiProperty(name: "componentName", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#value_overrides DifStack#value_overrides}.</summary>
        [JsiiProperty(name: "valueOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> ValueOverrides
        {
            get;
            set;
        }
    }
}
