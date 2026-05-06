using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    [JsiiInterface(nativeType: typeof(ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings")]
    public interface ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#query_field CloudGuardDetectorRecipe#query_field}.</summary>
        [JsiiProperty(name: "queryField", typeJson: "{\"primitive\":\"string\"}")]
        string QueryField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#display_name CloudGuardDetectorRecipe#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#entity_type CloudGuardDetectorRecipe#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntityType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings), fullyQualifiedName: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#query_field CloudGuardDetectorRecipe#query_field}.</summary>
            [JsiiProperty(name: "queryField", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#display_name CloudGuardDetectorRecipe#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#entity_type CloudGuardDetectorRecipe#entity_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntityType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
