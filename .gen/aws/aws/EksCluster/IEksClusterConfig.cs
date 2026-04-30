using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterConfig), fullyQualifiedName: "aws.eksCluster.EksClusterConfig")]
    public interface IEksClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#name EksCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#role_arn EksCluster#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#vpc_config EksCluster#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterVpcConfig\"}")]
        aws.EksCluster.IEksClusterVpcConfig VpcConfig
        {
            get;
        }

        /// <summary>access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#access_config EksCluster#access_config}
        /// </remarks>
        [JsiiProperty(name: "accessConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterAccessConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterAccessConfig? AccessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#bootstrap_self_managed_addons EksCluster#bootstrap_self_managed_addons}.</summary>
        [JsiiProperty(name: "bootstrapSelfManagedAddons", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BootstrapSelfManagedAddons
        {
            get
            {
                return null;
            }
        }

        /// <summary>compute_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#compute_config EksCluster#compute_config}
        /// </remarks>
        [JsiiProperty(name: "computeConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterComputeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterComputeConfig? ComputeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>control_plane_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#control_plane_scaling_config EksCluster#control_plane_scaling_config}
        /// </remarks>
        [JsiiProperty(name: "controlPlaneScalingConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterControlPlaneScalingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterControlPlaneScalingConfig? ControlPlaneScalingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#deletion_protection EksCluster#deletion_protection}.</summary>
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeletionProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#enabled_cluster_log_types EksCluster#enabled_cluster_log_types}.</summary>
        [JsiiProperty(name: "enabledClusterLogTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EnabledClusterLogTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#encryption_config EksCluster#encryption_config}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterEncryptionConfig? EncryptionConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#force_update_version EksCluster#force_update_version}.</summary>
        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceUpdateVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#id EksCluster#id}.</summary>
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

        /// <summary>kubernetes_network_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#kubernetes_network_config EksCluster#kubernetes_network_config}
        /// </remarks>
        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterKubernetesNetworkConfig? KubernetesNetworkConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>outpost_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#outpost_config EksCluster#outpost_config}
        /// </remarks>
        [JsiiProperty(name: "outpostConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterOutpostConfig? OutpostConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#region EksCluster#region}
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

        /// <summary>remote_network_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#remote_network_config EksCluster#remote_network_config}
        /// </remarks>
        [JsiiProperty(name: "remoteNetworkConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterRemoteNetworkConfig? RemoteNetworkConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#storage_config EksCluster#storage_config}
        /// </remarks>
        [JsiiProperty(name: "storageConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterStorageConfig? StorageConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#tags EksCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#tags_all EksCluster#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#timeouts EksCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#upgrade_policy EksCluster#upgrade_policy}
        /// </remarks>
        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterUpgradePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterUpgradePolicy? UpgradePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#version EksCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>zonal_shift_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#zonal_shift_config EksCluster#zonal_shift_config}
        /// </remarks>
        [JsiiProperty(name: "zonalShiftConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterZonalShiftConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterZonalShiftConfig? ZonalShiftConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterConfig), fullyQualifiedName: "aws.eksCluster.EksClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#name EksCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#role_arn EksCluster#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#vpc_config EksCluster#vpc_config}
            /// </remarks>
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterVpcConfig\"}")]
            public aws.EksCluster.IEksClusterVpcConfig VpcConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterVpcConfig>()!;
            }

            /// <summary>access_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#access_config EksCluster#access_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterAccessConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterAccessConfig? AccessConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterAccessConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#bootstrap_self_managed_addons EksCluster#bootstrap_self_managed_addons}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bootstrapSelfManagedAddons", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BootstrapSelfManagedAddons
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>compute_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#compute_config EksCluster#compute_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterComputeConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterComputeConfig? ComputeConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterComputeConfig?>();
            }

            /// <summary>control_plane_scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#control_plane_scaling_config EksCluster#control_plane_scaling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controlPlaneScalingConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterControlPlaneScalingConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterControlPlaneScalingConfig? ControlPlaneScalingConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterControlPlaneScalingConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#deletion_protection EksCluster#deletion_protection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeletionProtection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#enabled_cluster_log_types EksCluster#enabled_cluster_log_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabledClusterLogTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EnabledClusterLogTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>encryption_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#encryption_config EksCluster#encryption_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterEncryptionConfig? EncryptionConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterEncryptionConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#force_update_version EksCluster#force_update_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceUpdateVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#id EksCluster#id}.</summary>
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

            /// <summary>kubernetes_network_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#kubernetes_network_config EksCluster#kubernetes_network_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterKubernetesNetworkConfig? KubernetesNetworkConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterKubernetesNetworkConfig?>();
            }

            /// <summary>outpost_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#outpost_config EksCluster#outpost_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outpostConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterOutpostConfig? OutpostConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfig?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#region EksCluster#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>remote_network_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#remote_network_config EksCluster#remote_network_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteNetworkConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterRemoteNetworkConfig? RemoteNetworkConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfig?>();
            }

            /// <summary>storage_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#storage_config EksCluster#storage_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterStorageConfig? StorageConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterStorageConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#tags EksCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#tags_all EksCluster#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#timeouts EksCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterTimeouts\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterTimeouts?>();
            }

            /// <summary>upgrade_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#upgrade_policy EksCluster#upgrade_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterUpgradePolicy\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterUpgradePolicy? UpgradePolicy
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterUpgradePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#version EksCluster#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>zonal_shift_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#zonal_shift_config EksCluster#zonal_shift_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zonalShiftConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterZonalShiftConfig\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterZonalShiftConfig? ZonalShiftConfig
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterZonalShiftConfig?>();
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
