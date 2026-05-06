using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiByValue(fqn: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails")]
    public class CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails : oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails
    {
        private object? _conditionGroups;

        /// <summary>condition_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#condition_groups CloudGuardTarget#condition_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConditionGroups
        {
            get => _conditionGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditionGroups = value;
            }
        }
    }
}
