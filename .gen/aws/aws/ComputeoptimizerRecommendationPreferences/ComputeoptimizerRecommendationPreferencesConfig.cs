using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComputeoptimizerRecommendationPreferences
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesConfig")]
    public class ComputeoptimizerRecommendationPreferencesConfig : aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#resource_type ComputeoptimizerRecommendationPreferences#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#enhanced_infrastructure_metrics ComputeoptimizerRecommendationPreferences#enhanced_infrastructure_metrics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enhancedInfrastructureMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnhancedInfrastructureMetrics
        {
            get;
            set;
        }

        private object? _externalMetricsPreference;

        /// <summary>external_metrics_preference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#external_metrics_preference ComputeoptimizerRecommendationPreferences#external_metrics_preference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalMetricsPreference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExternalMetricsPreference
        {
            get => _externalMetricsPreference;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesExternalMetricsPreference[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesExternalMetricsPreference).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _externalMetricsPreference = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#inferred_workload_types ComputeoptimizerRecommendationPreferences#inferred_workload_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferredWorkloadTypes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferredWorkloadTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#look_back_period ComputeoptimizerRecommendationPreferences#look_back_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lookBackPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LookBackPeriod
        {
            get;
            set;
        }

        private object? _preferredResource;

        /// <summary>preferred_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#preferred_resource ComputeoptimizerRecommendationPreferences#preferred_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferredResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PreferredResource
        {
            get => _preferredResource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesPreferredResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesPreferredResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preferredResource = value;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#region ComputeoptimizerRecommendationPreferences#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#savings_estimation_mode ComputeoptimizerRecommendationPreferences#savings_estimation_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "savingsEstimationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SavingsEstimationMode
        {
            get;
            set;
        }

        private object? _scope;

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#scope ComputeoptimizerRecommendationPreferences#scope}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Scope
        {
            get => _scope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scope = value;
            }
        }

        private object? _utilizationPreference;

        /// <summary>utilization_preference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/computeoptimizer_recommendation_preferences#utilization_preference ComputeoptimizerRecommendationPreferences#utilization_preference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "utilizationPreference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UtilizationPreference
        {
            get => _utilizationPreference;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreference[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreference).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _utilizationPreference = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
