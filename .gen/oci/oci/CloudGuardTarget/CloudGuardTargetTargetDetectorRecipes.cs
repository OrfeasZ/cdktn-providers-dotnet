using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipes")]
    public class CloudGuardTargetTargetDetectorRecipes : oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_recipe_id CloudGuardTarget#detector_recipe_id}.</summary>
        [JsiiProperty(name: "detectorRecipeId", typeJson: "{\"primitive\":\"string\"}")]
        public string DetectorRecipeId
        {
            get;
            set;
        }

        private object? _detectorRules;

        /// <summary>detector_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_rules CloudGuardTarget#detector_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "detectorRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DetectorRules
        {
            get => _detectorRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _detectorRules = value;
            }
        }
    }
}
