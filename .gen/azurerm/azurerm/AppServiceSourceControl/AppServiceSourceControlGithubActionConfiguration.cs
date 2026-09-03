using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControl
{
    [JsiiByValue(fqn: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfiguration")]
    public class AppServiceSourceControlGithubActionConfiguration : azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfiguration
    {
        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#code_configuration AppServiceSourceControl#code_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
        public azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration? CodeConfiguration
        {
            get;
            set;
        }

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#container_configuration AppServiceSourceControl#container_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
        public azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration? ContainerConfiguration
        {
            get;
            set;
        }

        private object? _generateWorkflowFile;

        /// <summary>Should the service generate the GitHub Action Workflow file. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#generate_workflow_file AppServiceSourceControl#generate_workflow_file}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generateWorkflowFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? GenerateWorkflowFile
        {
            get => _generateWorkflowFile;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _generateWorkflowFile = value;
            }
        }
    }
}
