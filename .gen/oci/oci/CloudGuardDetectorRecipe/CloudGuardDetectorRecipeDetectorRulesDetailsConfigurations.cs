using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurations")]
    public class CloudGuardDetectorRecipeDetectorRulesDetailsConfigurations : oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#config_key CloudGuardDetectorRecipe#config_key}.</summary>
        [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#name CloudGuardDetectorRecipe#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _additionalProperties;

        /// <summary>additional_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#additional_properties CloudGuardDetectorRecipe#additional_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalProperties
        {
            get => _additionalProperties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAdditionalProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalProperties = value;
            }
        }

        private object? _allowedValues;

        /// <summary>allowed_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#allowed_values CloudGuardDetectorRecipe#allowed_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedValues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowedValues
        {
            get => _allowedValues;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsAllowedValues).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowedValues = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#allowed_values_data_type CloudGuardDetectorRecipe#allowed_values_data_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedValuesDataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowedValuesDataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#data_type CloudGuardDetectorRecipe#data_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#value CloudGuardDetectorRecipe#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }

        private object? _values;

        /// <summary>values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#values CloudGuardDetectorRecipe#values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Values
        {
            get => _values;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsValues[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetailsConfigurationsValues).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _values = value;
            }
        }
    }
}
