using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionJobs), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobs")]
    public interface IBuildDefinitionJobs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#condition BuildDefinition#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        string Condition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#name BuildDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#ref_name BuildDefinition#ref_name}.</summary>
        [JsiiProperty(name: "refName", typeJson: "{\"primitive\":\"string\"}")]
        string RefName
        {
            get;
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#target BuildDefinition#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTarget\"}")]
        azuredevops.BuildDefinition.IBuildDefinitionJobsTarget Target
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#allow_scripts_auth_access_option BuildDefinition#allow_scripts_auth_access_option}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowScriptsAuthAccessOption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowScriptsAuthAccessOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>dependencies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#dependencies BuildDefinition#dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dependencies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_authorization_scope BuildDefinition#job_authorization_scope}.</summary>
        [JsiiProperty(name: "jobAuthorizationScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobAuthorizationScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_cancel_timeout_in_minutes BuildDefinition#job_cancel_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "jobCancelTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JobCancelTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_timeout_in_minutes BuildDefinition#job_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "jobTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JobTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionJobs), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobs")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionJobs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#condition BuildDefinition#condition}.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
            public string Condition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#name BuildDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#ref_name BuildDefinition#ref_name}.</summary>
            [JsiiProperty(name: "refName", typeJson: "{\"primitive\":\"string\"}")]
            public string RefName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#target BuildDefinition#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTarget\"}")]
            public azuredevops.BuildDefinition.IBuildDefinitionJobsTarget Target
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionJobsTarget>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#allow_scripts_auth_access_option BuildDefinition#allow_scripts_auth_access_option}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowScriptsAuthAccessOption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowScriptsAuthAccessOption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dependencies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#dependencies BuildDefinition#dependencies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dependencies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_authorization_scope BuildDefinition#job_authorization_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobAuthorizationScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobAuthorizationScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_cancel_timeout_in_minutes BuildDefinition#job_cancel_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobCancelTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JobCancelTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#job_timeout_in_minutes BuildDefinition#job_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JobTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
