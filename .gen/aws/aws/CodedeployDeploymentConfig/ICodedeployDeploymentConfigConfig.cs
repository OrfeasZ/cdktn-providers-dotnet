using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigConfig")]
    public interface ICodedeployDeploymentConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#deployment_config_name CodedeployDeploymentConfig#deployment_config_name}.</summary>
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentConfigName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#compute_platform CodedeployDeploymentConfig#compute_platform}.</summary>
        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputePlatform
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#id CodedeployDeploymentConfig#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum_healthy_hosts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#minimum_healthy_hosts CodedeployDeploymentConfig#minimum_healthy_hosts}
        /// </remarks>
        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#region CodedeployDeploymentConfig#region}
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

        /// <summary>traffic_routing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#traffic_routing_config CodedeployDeploymentConfig#traffic_routing_config}
        /// </remarks>
        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>zonal_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#zonal_config CodedeployDeploymentConfig#zonal_config}
        /// </remarks>
        [JsiiProperty(name: "zonalConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig? ZonalConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#deployment_config_name CodedeployDeploymentConfig#deployment_config_name}.</summary>
            [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentConfigName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#compute_platform CodedeployDeploymentConfig#compute_platform}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputePlatform
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#id CodedeployDeploymentConfig#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>minimum_healthy_hosts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#minimum_healthy_hosts CodedeployDeploymentConfig#minimum_healthy_hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
            public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHosts
            {
                get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#region CodedeployDeploymentConfig#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>traffic_routing_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#traffic_routing_config CodedeployDeploymentConfig#traffic_routing_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
            public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfig
            {
                get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig?>();
            }

            /// <summary>zonal_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_config#zonal_config CodedeployDeploymentConfig#zonal_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zonalConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig\"}", isOptional: true)]
            public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig? ZonalConfig
            {
                get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig?>();
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
