using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance oci_bds_bds_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.BdsBdsInstance.BdsBdsInstance), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceConfig\"}}]")]
    public class BdsBdsInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance oci_bds_bds_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BdsBdsInstance(Constructs.Construct scope, string id, oci.BdsBdsInstance.IBdsBdsInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BdsBdsInstance.IBdsBdsInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BdsBdsInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BdsBdsInstance to import.</param>
        /// <param name="importFromId">The id of the existing BdsBdsInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BdsBdsInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BdsBdsInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BdsBdsInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BdsBdsInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BdsBdsInstance.BdsBdsInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBdsClusterVersionSummary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummary\"}}]")]
        public virtual void PutBdsClusterVersionSummary(oci.BdsBdsInstance.IBdsBdsInstanceBdsClusterVersionSummary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceBdsClusterVersionSummary)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCloudSqlDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceCloudSqlDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCloudSqlDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.BdsBdsInstance.IBdsBdsInstanceCloudSqlDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsBdsInstance.IBdsBdsInstanceCloudSqlDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsBdsInstance.IBdsBdsInstanceCloudSqlDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComputeOnlyWorkerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNode\"}}]")]
        public virtual void PutComputeOnlyWorkerNode(oci.BdsBdsInstance.IBdsBdsInstanceComputeOnlyWorkerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceComputeOnlyWorkerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEdgeNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceEdgeNode\"}}]")]
        public virtual void PutEdgeNode(oci.BdsBdsInstance.IBdsBdsInstanceEdgeNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceEdgeNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaBrokerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNode\"}}]")]
        public virtual void PutKafkaBrokerNode(oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceMasterNode\"}}]")]
        public virtual void PutMasterNode(oci.BdsBdsInstance.IBdsBdsInstanceMasterNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceMasterNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceNetworkConfig\"}}]")]
        public virtual void PutNetworkConfig(oci.BdsBdsInstance.IBdsBdsInstanceNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceNetworkConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStartClusterShapeConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStartClusterShapeConfigs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BdsBdsInstance.IBdsBdsInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUtilNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceUtilNode\"}}]")]
        public virtual void PutUtilNode(oci.BdsBdsInstance.IBdsBdsInstanceUtilNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceUtilNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNode\"}}]")]
        public virtual void PutWorkerNode(oci.BdsBdsInstance.IBdsBdsInstanceWorkerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceWorkerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBdsClusterVersionSummary")]
        public virtual void ResetBdsClusterVersionSummary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootstrapScriptUrl")]
        public virtual void ResetBootstrapScriptUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudSqlDetails")]
        public virtual void ResetCloudSqlDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterProfile")]
        public virtual void ResetClusterProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeOnlyWorkerNode")]
        public virtual void ResetComputeOnlyWorkerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgeNode")]
        public virtual void ResetEdgeNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreExistingNodesShape")]
        public virtual void ResetIgnoreExistingNodesShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsCloudSqlConfigured")]
        public virtual void ResetIsCloudSqlConfigured()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsForceRemoveEnabled")]
        public virtual void ResetIsForceRemoveEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsForceStopJobs")]
        public virtual void ResetIsForceStopJobs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsKafkaConfigured")]
        public virtual void ResetIsKafkaConfigured()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafkaBrokerNode")]
        public virtual void ResetKafkaBrokerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosRealmName")]
        public virtual void ResetKerberosRealmName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfig")]
        public virtual void ResetNetworkConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsPatchVersion")]
        public virtual void ResetOsPatchVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoveNode")]
        public virtual void ResetRemoveNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartClusterShapeConfigs")]
        public virtual void ResetStartClusterShapeConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.BdsBdsInstance.BdsBdsInstance))!;

        [JsiiProperty(name: "bdsClusterVersionSummary", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummaryOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummaryOutputReference BdsClusterVersionSummary
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummaryOutputReference>()!;
        }

        [JsiiProperty(name: "cloudSqlDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceCloudSqlDetailsList\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceCloudSqlDetailsList CloudSqlDetails
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceCloudSqlDetailsList>()!;
        }

        [JsiiProperty(name: "clusterDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceClusterDetailsList\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceClusterDetailsList ClusterDetails
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceClusterDetailsList>()!;
        }

        [JsiiProperty(name: "computeOnlyWorkerNode", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNodeOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNodeOutputReference ComputeOnlyWorkerNode
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNodeOutputReference>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceEdgeNodeOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceEdgeNodeOutputReference EdgeNode
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceEdgeNodeOutputReference>()!;
        }

        [JsiiProperty(name: "kafkaBrokerNode", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeOutputReference KafkaBrokerNode
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeOutputReference>()!;
        }

        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceMasterNodeOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceMasterNodeOutputReference MasterNode
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceMasterNodeOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceNetworkConfigOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceNetworkConfigOutputReference NetworkConfig
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceNodesList\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceNodesList Nodes
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceNodesList>()!;
        }

        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfNodesRequiringMaintenanceReboot", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodesRequiringMaintenanceReboot
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "startClusterShapeConfigs", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsList\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsList StartClusterShapeConfigs
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceTimeoutsOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "utilNode", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceUtilNodeOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceUtilNodeOutputReference UtilNode
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceUtilNodeOutputReference>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNodeOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceWorkerNodeOutputReference WorkerNode
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceWorkerNodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsClusterVersionSummaryInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummary\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceBdsClusterVersionSummary? BdsClusterVersionSummaryInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceBdsClusterVersionSummary?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapScriptUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootstrapScriptUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudSqlDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceCloudSqlDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CloudSqlDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterProfileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPublicKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterPublicKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeOnlyWorkerNodeInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceComputeOnlyWorkerNode? ComputeOnlyWorkerNodeInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceComputeOnlyWorkerNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeNodeInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceEdgeNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceEdgeNode? EdgeNodeInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceEdgeNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreExistingNodesShapeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IgnoreExistingNodesShapeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isCloudSqlConfiguredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsCloudSqlConfiguredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isForceRemoveEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsForceRemoveEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isForceStopJobsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsForceStopJobsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isHighAvailabilityInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsHighAvailabilityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isKafkaConfiguredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsKafkaConfiguredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSecureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSecureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaBrokerNodeInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNode? KafkaBrokerNodeInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosRealmNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KerberosRealmNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceMasterNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceMasterNode? MasterNodeInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceMasterNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceNetworkConfig\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceNetworkConfig? NetworkConfigInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceNetworkConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osPatchVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsPatchVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "removeNodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoveNodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startClusterShapeConfigsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StartClusterShapeConfigsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "utilNodeInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceUtilNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceUtilNode? UtilNodeInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceUtilNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerNodeInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceWorkerNode? WorkerNodeInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceWorkerNode?>();
        }

        [JsiiProperty(name: "bootstrapScriptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapScriptUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterProfile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPublicKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignoreExistingNodesShape", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IgnoreExistingNodesShape
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isCloudSqlConfigured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsCloudSqlConfigured
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isForceRemoveEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsForceRemoveEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isForceStopJobs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsForceStopJobs
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isHighAvailability", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsHighAvailability
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isKafkaConfigured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsKafkaConfigured
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isSecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSecure
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "kerberosRealmName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosRealmName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osPatchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsPatchVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "removeNode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoveNode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
