using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackInstances
{
    [JsiiInterface(nativeType: typeof(ICloudformationStackInstancesConfig), fullyQualifiedName: "aws.cloudformationStackInstances.CloudformationStackInstancesConfig")]
    public interface ICloudformationStackInstancesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#stack_set_name CloudformationStackInstances#stack_set_name}.</summary>
        [JsiiProperty(name: "stackSetName", typeJson: "{\"primitive\":\"string\"}")]
        string StackSetName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#accounts CloudformationStackInstances#accounts}.</summary>
        [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Accounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#call_as CloudformationStackInstances#call_as}.</summary>
        [JsiiProperty(name: "callAs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CallAs
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#deployment_targets CloudformationStackInstances#deployment_targets}
        /// </remarks>
        [JsiiProperty(name: "deploymentTargets", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesDeploymentTargets\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets? DeploymentTargets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#id CloudformationStackInstances#id}.</summary>
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

        /// <summary>operation_preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#operation_preferences CloudformationStackInstances#operation_preferences}
        /// </remarks>
        [JsiiProperty(name: "operationPreferences", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferences\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences? OperationPreferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#parameter_overrides CloudformationStackInstances#parameter_overrides}.</summary>
        [JsiiProperty(name: "parameterOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? ParameterOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#region CloudformationStackInstances#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#regions CloudformationStackInstances#regions}.</summary>
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Regions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#retain_stacks CloudformationStackInstances#retain_stacks}.</summary>
        [JsiiProperty(name: "retainStacks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RetainStacks
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#timeouts CloudformationStackInstances#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudformationStackInstances.ICloudformationStackInstancesTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudformationStackInstancesConfig), fullyQualifiedName: "aws.cloudformationStackInstances.CloudformationStackInstancesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudformationStackInstances.ICloudformationStackInstancesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#stack_set_name CloudformationStackInstances#stack_set_name}.</summary>
            [JsiiProperty(name: "stackSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string StackSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#accounts CloudformationStackInstances#accounts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Accounts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#call_as CloudformationStackInstances#call_as}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "callAs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CallAs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deployment_targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#deployment_targets CloudformationStackInstances#deployment_targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentTargets", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesDeploymentTargets\"}", isOptional: true)]
            public aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets? DeploymentTargets
            {
                get => GetInstanceProperty<aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#id CloudformationStackInstances#id}.</summary>
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

            /// <summary>operation_preferences block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#operation_preferences CloudformationStackInstances#operation_preferences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operationPreferences", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferences\"}", isOptional: true)]
            public aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences? OperationPreferences
            {
                get => GetInstanceProperty<aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#parameter_overrides CloudformationStackInstances#parameter_overrides}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameterOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? ParameterOverrides
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#region CloudformationStackInstances#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#regions CloudformationStackInstances#regions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Regions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#retain_stacks CloudformationStackInstances#retain_stacks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retainStacks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RetainStacks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudformation_stack_instances#timeouts CloudformationStackInstances#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesTimeouts\"}", isOptional: true)]
            public aws.CloudformationStackInstances.ICloudformationStackInstancesTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.CloudformationStackInstances.ICloudformationStackInstancesTimeouts?>();
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
