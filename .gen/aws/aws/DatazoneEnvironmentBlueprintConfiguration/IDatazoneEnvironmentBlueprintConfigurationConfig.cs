using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneEnvironmentBlueprintConfiguration
{
    [JsiiInterface(nativeType: typeof(IDatazoneEnvironmentBlueprintConfigurationConfig), fullyQualifiedName: "aws.datazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfigurationConfig")]
    public interface IDatazoneEnvironmentBlueprintConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#domain_id DatazoneEnvironmentBlueprintConfiguration#domain_id}.</summary>
        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        string DomainId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#enabled_regions DatazoneEnvironmentBlueprintConfiguration#enabled_regions}.</summary>
        [JsiiProperty(name: "enabledRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] EnabledRegions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#environment_blueprint_id DatazoneEnvironmentBlueprintConfiguration#environment_blueprint_id}.</summary>
        [JsiiProperty(name: "environmentBlueprintId", typeJson: "{\"primitive\":\"string\"}")]
        string EnvironmentBlueprintId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#manage_access_role_arn DatazoneEnvironmentBlueprintConfiguration#manage_access_role_arn}.</summary>
        [JsiiProperty(name: "manageAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManageAccessRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#provisioning_role_arn DatazoneEnvironmentBlueprintConfiguration#provisioning_role_arn}.</summary>
        [JsiiProperty(name: "provisioningRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProvisioningRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#region DatazoneEnvironmentBlueprintConfiguration#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#regional_parameters DatazoneEnvironmentBlueprintConfiguration#regional_parameters}.</summary>
        [JsiiProperty(name: "regionalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegionalParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazoneEnvironmentBlueprintConfigurationConfig), fullyQualifiedName: "aws.datazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DatazoneEnvironmentBlueprintConfiguration.IDatazoneEnvironmentBlueprintConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#domain_id DatazoneEnvironmentBlueprintConfiguration#domain_id}.</summary>
            [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#enabled_regions DatazoneEnvironmentBlueprintConfiguration#enabled_regions}.</summary>
            [JsiiProperty(name: "enabledRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] EnabledRegions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#environment_blueprint_id DatazoneEnvironmentBlueprintConfiguration#environment_blueprint_id}.</summary>
            [JsiiProperty(name: "environmentBlueprintId", typeJson: "{\"primitive\":\"string\"}")]
            public string EnvironmentBlueprintId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#manage_access_role_arn DatazoneEnvironmentBlueprintConfiguration#manage_access_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manageAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManageAccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#provisioning_role_arn DatazoneEnvironmentBlueprintConfiguration#provisioning_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisioningRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProvisioningRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#region DatazoneEnvironmentBlueprintConfiguration#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/datazone_environment_blueprint_configuration#regional_parameters DatazoneEnvironmentBlueprintConfiguration#regional_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regionalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? RegionalParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
