using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OutpostsCapacityTask
{
    [JsiiInterface(nativeType: typeof(IOutpostsCapacityTaskConfig), fullyQualifiedName: "aws.outpostsCapacityTask.OutpostsCapacityTaskConfig")]
    public interface IOutpostsCapacityTaskConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#outpost_identifier OutpostsCapacityTask#outpost_identifier}.</summary>
        [JsiiProperty(name: "outpostIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string OutpostIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#asset_id OutpostsCapacityTask#asset_id}.</summary>
        [JsiiProperty(name: "assetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#instance_pool OutpostsCapacityTask#instance_pool}
        /// </remarks>
        [JsiiProperty(name: "instancePool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.outpostsCapacityTask.OutpostsCapacityTaskInstancePool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstancePool
        {
            get
            {
                return null;
            }
        }

        /// <summary>instances_to_exclude block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#instances_to_exclude OutpostsCapacityTask#instances_to_exclude}
        /// </remarks>
        [JsiiProperty(name: "instancesToExclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.outpostsCapacityTask.OutpostsCapacityTaskInstancesToExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstancesToExclude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#order_id OutpostsCapacityTask#order_id}.</summary>
        [JsiiProperty(name: "orderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#region OutpostsCapacityTask#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#task_action_on_blocking_instances OutpostsCapacityTask#task_action_on_blocking_instances}.</summary>
        [JsiiProperty(name: "taskActionOnBlockingInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskActionOnBlockingInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#timeouts OutpostsCapacityTask#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.outpostsCapacityTask.OutpostsCapacityTaskTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OutpostsCapacityTask.IOutpostsCapacityTaskTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOutpostsCapacityTaskConfig), fullyQualifiedName: "aws.outpostsCapacityTask.OutpostsCapacityTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OutpostsCapacityTask.IOutpostsCapacityTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#outpost_identifier OutpostsCapacityTask#outpost_identifier}.</summary>
            [JsiiProperty(name: "outpostIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string OutpostIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#asset_id OutpostsCapacityTask#asset_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#instance_pool OutpostsCapacityTask#instance_pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instancePool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.outpostsCapacityTask.OutpostsCapacityTaskInstancePool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InstancePool
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>instances_to_exclude block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#instances_to_exclude OutpostsCapacityTask#instances_to_exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instancesToExclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.outpostsCapacityTask.OutpostsCapacityTaskInstancesToExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InstancesToExclude
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#order_id OutpostsCapacityTask#order_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#region OutpostsCapacityTask#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#task_action_on_blocking_instances OutpostsCapacityTask#task_action_on_blocking_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskActionOnBlockingInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskActionOnBlockingInstances
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#timeouts OutpostsCapacityTask#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.outpostsCapacityTask.OutpostsCapacityTaskTimeouts\"}", isOptional: true)]
            public aws.OutpostsCapacityTask.IOutpostsCapacityTaskTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OutpostsCapacityTask.IOutpostsCapacityTaskTimeouts?>();
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
