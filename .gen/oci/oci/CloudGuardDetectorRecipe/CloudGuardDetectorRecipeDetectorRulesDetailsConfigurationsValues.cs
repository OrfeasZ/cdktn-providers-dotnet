using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsValues")]
    public class CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsValues : oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#list_type CloudGuardDetectorRecipe#list_type}.</summary>
        [JsiiProperty(name: "listType", typeJson: "{\"primitive\":\"string\"}")]
        public string ListType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#managed_list_type CloudGuardDetectorRecipe#managed_list_type}.</summary>
        [JsiiProperty(name: "managedListType", typeJson: "{\"primitive\":\"string\"}")]
        public string ManagedListType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#value CloudGuardDetectorRecipe#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
