using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    [JsiiInterface(nativeType: typeof(ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties")]
    public interface ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#key CloudGuardDetectorRecipe#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#property_type CloudGuardDetectorRecipe#property_type}.</summary>
        [JsiiProperty(name: "propertyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropertyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#value CloudGuardDetectorRecipe#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#key CloudGuardDetectorRecipe#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#property_type CloudGuardDetectorRecipe#property_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propertyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropertyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#value CloudGuardDetectorRecipe#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
