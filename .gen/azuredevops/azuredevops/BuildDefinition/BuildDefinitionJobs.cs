using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionJobs")]
    public class BuildDefinitionJobs : azuredevops.BuildDefinition.IBuildDefinitionJobs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#condition BuildDefinition#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public string Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#name BuildDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#ref_name BuildDefinition#ref_name}.</summary>
        [JsiiProperty(name: "refName", typeJson: "{\"primitive\":\"string\"}")]
        public string RefName
        {
            get;
            set;
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#target BuildDefinition#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTarget\"}")]
        public azuredevops.BuildDefinition.IBuildDefinitionJobsTarget Target
        {
            get;
            set;
        }

        private object? _allowScriptsAuthAccessOption;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#allow_scripts_auth_access_option BuildDefinition#allow_scripts_auth_access_option}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowScriptsAuthAccessOption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowScriptsAuthAccessOption
        {
            get => _allowScriptsAuthAccessOption;
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
                _allowScriptsAuthAccessOption = value;
            }
        }

        private object? _dependencies;

        /// <summary>dependencies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#dependencies BuildDefinition#dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dependencies
        {
            get => _dependencies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dependencies = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#job_authorization_scope BuildDefinition#job_authorization_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobAuthorizationScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobAuthorizationScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#job_cancel_timeout_in_minutes BuildDefinition#job_cancel_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobCancelTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? JobCancelTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/build_definition#job_timeout_in_minutes BuildDefinition#job_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? JobTimeoutInMinutes
        {
            get;
            set;
        }
    }
}
