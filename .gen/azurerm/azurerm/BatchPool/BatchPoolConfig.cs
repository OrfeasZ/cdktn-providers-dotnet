using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolConfig")]
    public class BatchPoolConfig : azurerm.BatchPool.IBatchPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#account_name BatchPool#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#name BatchPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#node_agent_sku_id BatchPool#node_agent_sku_id}.</summary>
        [JsiiProperty(name: "nodeAgentSkuId", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeAgentSkuId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#resource_group_name BatchPool#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>storage_image_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#storage_image_reference BatchPool#storage_image_reference}
        /// </remarks>
        [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStorageImageReference\"}")]
        public azurerm.BatchPool.IBatchPoolStorageImageReference StorageImageReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#vm_size BatchPool#vm_size}.</summary>
        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public string VmSize
        {
            get;
            set;
        }

        /// <summary>auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#auto_scale BatchPool#auto_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolAutoScale\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolAutoScale? AutoScale
        {
            get;
            set;
        }

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#container_configuration BatchPool#container_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolContainerConfiguration\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolContainerConfiguration? ContainerConfiguration
        {
            get;
            set;
        }

        private object? _dataDisks;

        /// <summary>data_disks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#data_disks BatchPool#data_disks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolDataDisks" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataDisks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolDataDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataDisks
        {
            get => _dataDisks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolDataDisks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolDataDisks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataDisks = value;
            }
        }

        private object? _diskEncryption;

        /// <summary>disk_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#disk_encryption BatchPool#disk_encryption}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolDiskEncryption" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DiskEncryption
        {
            get => _diskEncryption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolDiskEncryption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolDiskEncryption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _diskEncryption = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#display_name BatchPool#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        private object? _extensions;

        /// <summary>extensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#extensions BatchPool#extensions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolExtensions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolExtensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Extensions
        {
            get => _extensions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolExtensions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolExtensions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extensions = value;
            }
        }

        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#fixed_scale BatchPool#fixed_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolFixedScale\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolFixedScale? FixedScale
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#id BatchPool#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#identity BatchPool#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolIdentity\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolIdentity? Identity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#inter_node_communication BatchPool#inter_node_communication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interNodeCommunication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterNodeCommunication
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#license_type BatchPool#license_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#max_tasks_per_node BatchPool#max_tasks_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTasksPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTasksPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#metadata BatchPool#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        private object? _mount;

        /// <summary>mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#mount BatchPool#mount}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMount" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Mount
        {
            get => _mount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolMount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mount = value;
            }
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#network_configuration BatchPool#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfiguration\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        private object? _nodePlacement;

        /// <summary>node_placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#node_placement BatchPool#node_placement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolNodePlacement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodePlacement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNodePlacement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NodePlacement
        {
            get => _nodePlacement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolNodePlacement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolNodePlacement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nodePlacement = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#os_disk_placement BatchPool#os_disk_placement}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "osDiskPlacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OsDiskPlacement
        {
            get;
            set;
        }

        /// <summary>security_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#security_profile BatchPool#security_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolSecurityProfile\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolSecurityProfile? SecurityProfile
        {
            get;
            set;
        }

        /// <summary>start_task block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#start_task BatchPool#start_task}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startTask", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTask\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolStartTask? StartTask
        {
            get;
            set;
        }

        private object? _stopPendingResizeOperation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#stop_pending_resize_operation BatchPool#stop_pending_resize_operation}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stopPendingResizeOperation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StopPendingResizeOperation
        {
            get => _stopPendingResizeOperation;
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
                _stopPendingResizeOperation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#target_node_communication_mode BatchPool#target_node_communication_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetNodeCommunicationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetNodeCommunicationMode
        {
            get;
            set;
        }

        private object? _taskSchedulingPolicy;

        /// <summary>task_scheduling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#task_scheduling_policy BatchPool#task_scheduling_policy}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taskSchedulingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolTaskSchedulingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TaskSchedulingPolicy
        {
            get => _taskSchedulingPolicy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _taskSchedulingPolicy = value;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#timeouts BatchPool#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolTimeouts\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _userAccounts;

        /// <summary>user_accounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#user_accounts BatchPool#user_accounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolUserAccounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UserAccounts
        {
            get => _userAccounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolUserAccounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolUserAccounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _userAccounts = value;
            }
        }

        private object? _windows;

        /// <summary>windows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#windows BatchPool#windows}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolWindows" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Windows
        {
            get => _windows;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolWindows[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolWindows).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _windows = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
