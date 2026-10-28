using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecification")]
    public class SagemakerInferenceComponentSpecification : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#base_inference_component_name SagemakerInferenceComponent#base_inference_component_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseInferenceComponentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseInferenceComponentName
        {
            get;
            set;
        }

        private object? _computeResourceRequirements;

        /// <summary>compute_resource_requirements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#compute_resource_requirements SagemakerInferenceComponent#compute_resource_requirements}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationComputeResourceRequirements" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeResourceRequirements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationComputeResourceRequirements\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ComputeResourceRequirements
        {
            get => _computeResourceRequirements;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationComputeResourceRequirements[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationComputeResourceRequirements).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _computeResourceRequirements = value;
            }
        }

        private object? _container;

        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#container SagemakerInferenceComponent#container}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Container
        {
            get => _container;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _container = value;
            }
        }

        private object? _dataCacheConfig;

        /// <summary>data_cache_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#data_cache_config SagemakerInferenceComponent#data_cache_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationDataCacheConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataCacheConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationDataCacheConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataCacheConfig
        {
            get => _dataCacheConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationDataCacheConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationDataCacheConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataCacheConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#instance_type SagemakerInferenceComponent#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#model_name SagemakerInferenceComponent#model_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelName
        {
            get;
            set;
        }

        private object? _schedulingConfig;

        /// <summary>scheduling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#scheduling_config SagemakerInferenceComponent#scheduling_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationSchedulingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SchedulingConfig
        {
            get => _schedulingConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationSchedulingConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schedulingConfig = value;
            }
        }

        private object? _startupParameters;

        /// <summary>startup_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#startup_parameters SagemakerInferenceComponent#startup_parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationStartupParameters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startupParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationStartupParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StartupParameters
        {
            get => _startupParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationStartupParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationStartupParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _startupParameters = value;
            }
        }
    }
}
