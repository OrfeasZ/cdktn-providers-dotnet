using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.optimizerProfile.OptimizerProfileTargetCompartments")]
    public class OptimizerProfileTargetCompartments : oci.OptimizerProfile.IOptimizerProfileTargetCompartments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#items OptimizerProfile#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Items
        {
            get;
            set;
        }
    }
}
