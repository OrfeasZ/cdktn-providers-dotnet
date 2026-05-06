using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    [JsiiByValue(fqn: "oci.optimizerProfile.OptimizerProfileLevelsConfigurationItems")]
    public class OptimizerProfileLevelsConfigurationItems : oci.OptimizerProfile.IOptimizerProfileLevelsConfigurationItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#level OptimizerProfile#level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Level
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#recommendation_id OptimizerProfile#recommendation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecommendationId
        {
            get;
            set;
        }
    }
}
