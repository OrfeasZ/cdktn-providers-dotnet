using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerServiceDeploymentVersion
{
    [JsiiInterface(nativeType: typeof(ILightsailContainerServiceDeploymentVersionConfig), fullyQualifiedName: "aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionConfig")]
    public interface ILightsailContainerServiceDeploymentVersionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#container LightsailContainerServiceDeploymentVersion#container}
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionContainer\"},\"kind\":\"array\"}}]}}")]
        object Container
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#service_name LightsailContainerServiceDeploymentVersion#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#id LightsailContainerServiceDeploymentVersion#id}.</summary>
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

        /// <summary>public_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#public_endpoint LightsailContainerServiceDeploymentVersion#public_endpoint}
        /// </remarks>
        [JsiiProperty(name: "publicEndpoint", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpoint? PublicEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#region LightsailContainerServiceDeploymentVersion#region}
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#timeouts LightsailContainerServiceDeploymentVersion#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailContainerServiceDeploymentVersionConfig), fullyQualifiedName: "aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#container LightsailContainerServiceDeploymentVersion#container}
            /// </remarks>
            [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionContainer\"},\"kind\":\"array\"}}]}}")]
            public object Container
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#service_name LightsailContainerServiceDeploymentVersion#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#id LightsailContainerServiceDeploymentVersion#id}.</summary>
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

            /// <summary>public_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#public_endpoint LightsailContainerServiceDeploymentVersion#public_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicEndpoint", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpoint\"}", isOptional: true)]
            public aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpoint? PublicEndpoint
            {
                get => GetInstanceProperty<aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpoint?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#region LightsailContainerServiceDeploymentVersion#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lightsail_container_service_deployment_version#timeouts LightsailContainerServiceDeploymentVersion#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionTimeouts\"}", isOptional: true)]
            public aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionTimeouts?>();
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
