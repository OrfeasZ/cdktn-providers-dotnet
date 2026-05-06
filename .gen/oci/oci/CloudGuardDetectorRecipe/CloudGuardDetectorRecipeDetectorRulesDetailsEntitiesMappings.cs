using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings")]
    public class CloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings : oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#query_field CloudGuardDetectorRecipe#query_field}.</summary>
        [JsiiProperty(name: "queryField", typeJson: "{\"primitive\":\"string\"}")]
        public string QueryField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#display_name CloudGuardDetectorRecipe#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#entity_type CloudGuardDetectorRecipe#entity_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntityType
        {
            get;
            set;
        }
    }
}
