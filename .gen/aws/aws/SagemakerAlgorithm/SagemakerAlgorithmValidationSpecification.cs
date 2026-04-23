using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecification")]
    public class SagemakerAlgorithmValidationSpecification : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#validation_role SagemakerAlgorithm#validation_role}.</summary>
        [JsiiProperty(name: "validationRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ValidationRole
        {
            get;
            set;
        }

        private object? _validationProfiles;

        /// <summary>validation_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#validation_profiles SagemakerAlgorithm#validation_profiles}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validationProfiles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfiles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ValidationProfiles
        {
            get => _validationProfiles;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfiles[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfiles).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _validationProfiles = value;
            }
        }
    }
}
