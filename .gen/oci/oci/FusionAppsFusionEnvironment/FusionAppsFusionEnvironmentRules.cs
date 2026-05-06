using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentRules")]
    public class FusionAppsFusionEnvironmentRules : oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#action FusionAppsFusionEnvironment#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        private object _conditions;

        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#conditions FusionAppsFusionEnvironment#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentRulesConditions\"},\"kind\":\"array\"}}]}}")]
        public object Conditions
        {
            get => _conditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentRulesConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentRulesConditions).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentRulesConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#description FusionAppsFusionEnvironment#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
