using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2OrganizationConfiguration
{
    [JsiiInterface(nativeType: typeof(IInspector2OrganizationConfigurationAutoEnable), fullyQualifiedName: "aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnable")]
    public interface IInspector2OrganizationConfigurationAutoEnable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#ec2 Inspector2OrganizationConfiguration#ec2}.</summary>
        [JsiiProperty(name: "ec2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Ec2
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#ecr Inspector2OrganizationConfiguration#ecr}.</summary>
        [JsiiProperty(name: "ecr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Ecr
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#code_repository Inspector2OrganizationConfiguration#code_repository}.</summary>
        [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeRepository
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#lambda Inspector2OrganizationConfiguration#lambda}.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Lambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#lambda_code Inspector2OrganizationConfiguration#lambda_code}.</summary>
        [JsiiProperty(name: "lambdaCode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2OrganizationConfigurationAutoEnable), fullyQualifiedName: "aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnable")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationAutoEnable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#ec2 Inspector2OrganizationConfiguration#ec2}.</summary>
            [JsiiProperty(name: "ec2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Ec2
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#ecr Inspector2OrganizationConfiguration#ecr}.</summary>
            [JsiiProperty(name: "ecr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Ecr
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#code_repository Inspector2OrganizationConfiguration#code_repository}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CodeRepository
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#lambda Inspector2OrganizationConfiguration#lambda}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Lambda
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_organization_configuration#lambda_code Inspector2OrganizationConfiguration#lambda_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaCode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LambdaCode
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
