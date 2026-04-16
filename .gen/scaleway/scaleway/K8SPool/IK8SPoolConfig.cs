using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SPool
{
    [JsiiInterface(nativeType: typeof(IK8SPoolConfig), fullyQualifiedName: "scaleway.k8SPool.K8SPoolConfig")]
    public interface IK8SPoolConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the cluster on which this pool will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#cluster_id K8SPool#cluster_id}
        /// </remarks>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>The name of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#name K8SPool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Server type of the pool servers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#node_type K8SPool#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>Size of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#size K8SPool#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Enable the autohealing on the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#autohealing K8SPool#autohealing}
        /// </remarks>
        [JsiiProperty(name: "autohealing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autohealing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable the autoscaling on the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#autoscaling K8SPool#autoscaling}
        /// </remarks>
        [JsiiProperty(name: "autoscaling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autoscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Container runtime for the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#container_runtime K8SPool#container_runtime}
        /// </remarks>
        [JsiiProperty(name: "containerRuntime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerRuntime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#id K8SPool#id}.</summary>
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

        /// <summary>The Kubelet arguments to be used by this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#kubelet_args K8SPool#kubelet_args}
        /// </remarks>
        [JsiiProperty(name: "kubeletArgs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? KubeletArgs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum size of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#max_size K8SPool#max_size}
        /// </remarks>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum size of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#min_size K8SPool#min_size}
        /// </remarks>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the placement group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#placement_group_id K8SPool#placement_group_id}
        /// </remarks>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines if the public IP should be removed from the nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#public_ip_disabled K8SPool#public_ip_disabled}
        /// </remarks>
        [JsiiProperty(name: "publicIpDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicIpDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#region K8SPool#region}
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

        /// <summary>The size of the system volume of the nodes in gigabyte.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#root_volume_size_in_gb K8SPool#root_volume_size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "rootVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RootVolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>System volume type of the nodes composing the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#root_volume_type K8SPool#root_volume_type}
        /// </remarks>
        [JsiiProperty(name: "rootVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootVolumeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the security group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#security_group_id K8SPool#security_group_id}
        /// </remarks>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tags associated with the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#tags K8SPool#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#timeouts K8SPool#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.k8SPool.K8SPoolTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.K8SPool.IK8SPoolTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#upgrade_policy K8SPool#upgrade_policy}
        /// </remarks>
        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"scaleway.k8SPool.K8SPoolUpgradePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.K8SPool.IK8SPoolUpgradePolicy? UpgradePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to wait for the pool to be ready.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#wait_for_pool_ready K8SPool#wait_for_pool_ready}
        /// </remarks>
        [JsiiProperty(name: "waitForPoolReady", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WaitForPoolReady
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#zone K8SPool#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IK8SPoolConfig), fullyQualifiedName: "scaleway.k8SPool.K8SPoolConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.K8SPool.IK8SPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the cluster on which this pool will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#cluster_id K8SPool#cluster_id}
            /// </remarks>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#name K8SPool#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Server type of the pool servers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#node_type K8SPool#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Size of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#size K8SPool#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Enable the autohealing on the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#autohealing K8SPool#autohealing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autohealing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Autohealing
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enable the autoscaling on the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#autoscaling K8SPool#autoscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Autoscaling
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Container runtime for the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#container_runtime K8SPool#container_runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerRuntime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerRuntime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#id K8SPool#id}.</summary>
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

            /// <summary>The Kubelet arguments to be used by this pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#kubelet_args K8SPool#kubelet_args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubeletArgs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? KubeletArgs
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Maximum size of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#max_size K8SPool#max_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minimum size of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#min_size K8SPool#min_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the placement group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#placement_group_id K8SPool#placement_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines if the public IP should be removed from the nodes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#public_ip_disabled K8SPool#public_ip_disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicIpDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#region K8SPool#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The size of the system volume of the nodes in gigabyte.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#root_volume_size_in_gb K8SPool#root_volume_size_in_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RootVolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>System volume type of the nodes composing the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#root_volume_type K8SPool#root_volume_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootVolumeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the security group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#security_group_id K8SPool#security_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The tags associated with the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#tags K8SPool#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#timeouts K8SPool#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.k8SPool.K8SPoolTimeouts\"}", isOptional: true)]
            public scaleway.K8SPool.IK8SPoolTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.K8SPool.IK8SPoolTimeouts?>();
            }

            /// <summary>upgrade_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#upgrade_policy K8SPool#upgrade_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"scaleway.k8SPool.K8SPoolUpgradePolicy\"}", isOptional: true)]
            public scaleway.K8SPool.IK8SPoolUpgradePolicy? UpgradePolicy
            {
                get => GetInstanceProperty<scaleway.K8SPool.IK8SPoolUpgradePolicy?>();
            }

            /// <summary>Whether to wait for the pool to be ready.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#wait_for_pool_ready K8SPool#wait_for_pool_ready}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "waitForPoolReady", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WaitForPoolReady
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#zone K8SPool#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
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
