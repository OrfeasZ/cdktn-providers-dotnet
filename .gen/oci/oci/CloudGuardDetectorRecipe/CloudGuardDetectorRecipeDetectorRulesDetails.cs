using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetails")]
    public class CloudGuardDetectorRecipeDetectorRulesDetails : oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetails
    {
        private object _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#is_enabled CloudGuardDetectorRecipe#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#risk_level CloudGuardDetectorRecipe#risk_level}.</summary>
        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string RiskLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#condition CloudGuardDetectorRecipe#condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Condition
        {
            get;
            set;
        }

        private object? _configurations;

        /// <summary>configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#configurations CloudGuardDetectorRecipe#configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Configurations
        {
            get => _configurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _configurations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#data_source_id CloudGuardDetectorRecipe#data_source_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#description CloudGuardDetectorRecipe#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _entitiesMappings;

        /// <summary>entities_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#entities_mappings CloudGuardDetectorRecipe#entities_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entitiesMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EntitiesMappings
        {
            get => _entitiesMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsEntitiesMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _entitiesMappings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#labels CloudGuardDetectorRecipe#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#recommendation CloudGuardDetectorRecipe#recommendation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recommendation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Recommendation
        {
            get;
            set;
        }
    }
}
