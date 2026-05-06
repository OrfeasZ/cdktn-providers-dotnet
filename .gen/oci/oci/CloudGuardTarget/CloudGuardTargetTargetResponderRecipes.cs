using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipes")]
    public class CloudGuardTargetTargetResponderRecipes : oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_recipe_id CloudGuardTarget#responder_recipe_id}.</summary>
        [JsiiProperty(name: "responderRecipeId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResponderRecipeId
        {
            get;
            set;
        }

        private object? _responderRules;

        /// <summary>responder_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_rules CloudGuardTarget#responder_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responderRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponderRules
        {
            get => _responderRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responderRules = value;
            }
        }
    }
}
