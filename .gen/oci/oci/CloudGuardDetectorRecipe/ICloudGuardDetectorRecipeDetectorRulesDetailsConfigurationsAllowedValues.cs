using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    [JsiiInterface(nativeType: typeof(ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues")]
    public interface ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#key CloudGuardDetectorRecipe#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#value CloudGuardDetectorRecipe#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#key CloudGuardDetectorRecipe#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#value CloudGuardDetectorRecipe#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
