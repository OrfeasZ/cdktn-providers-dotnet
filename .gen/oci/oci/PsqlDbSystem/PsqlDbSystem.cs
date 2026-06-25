using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/psql_db_system oci_psql_db_system}.</summary>
    [JsiiClass(nativeType: typeof(oci.PsqlDbSystem.PsqlDbSystem), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemConfig\"}}]")]
    public class PsqlDbSystem : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/psql_db_system oci_psql_db_system} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PsqlDbSystem(Constructs.Construct scope, string id, oci.PsqlDbSystem.IPsqlDbSystemConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.PsqlDbSystem.IPsqlDbSystemConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystem(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PsqlDbSystem resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PsqlDbSystem to import.</param>
        /// <param name="importFromId">The id of the existing PsqlDbSystem that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PsqlDbSystem to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PsqlDbSystem to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/psql_db_system#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PsqlDbSystem that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PsqlDbSystem to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.PsqlDbSystem.PsqlDbSystem), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentials\"}}]")]
        public virtual void PutCredentials(oci.PsqlDbSystem.IPsqlDbSystemCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemCredentials)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemInstancesDetails" />)[]</param>
        [JsiiMethod(name: "putInstancesDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemInstancesDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInstancesDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.PsqlDbSystem.IPsqlDbSystemInstancesDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemInstancesDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemInstancesDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKerberosAuthDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetails\"}}]")]
        public virtual void PutKerberosAuthDetails(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagementPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicy\"}}]")]
        public virtual void PutManagementPolicy(oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemNetworkDetails\"}}]")]
        public virtual void PutNetworkDetails(oci.PsqlDbSystem.IPsqlDbSystemNetworkDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemNetworkDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOdspInsightDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetails\"}}]")]
        public virtual void PutOdspInsightDetails(oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemPatchOperations" />)[]</param>
        [JsiiMethod(name: "putPatchOperations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemPatchOperations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPatchOperations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.PsqlDbSystem.IPsqlDbSystemPatchOperations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemPatchOperations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemPatchOperations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemReplicationConfig\"}}]")]
        public virtual void PutReplicationConfig(oci.PsqlDbSystem.IPsqlDbSystemReplicationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemReplicationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemSource\"}}]")]
        public virtual void PutSource(oci.PsqlDbSystem.IPsqlDbSystemSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemStorageDetails\"}}]")]
        public virtual void PutStorageDetails(oci.PsqlDbSystem.IPsqlDbSystemStorageDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemStorageDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.PsqlDbSystem.IPsqlDbSystemTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplyChangeModeToStandAlone")]
        public virtual void ResetApplyChangeModeToStandAlone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplyConfig")]
        public virtual void ResetApplyConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigId")]
        public virtual void ResetConfigId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceMemorySizeInGbs")]
        public virtual void ResetInstanceMemorySizeInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceOcpuCount")]
        public virtual void ResetInstanceOcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstancesDetails")]
        public virtual void ResetInstancesDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosAuthDetails")]
        public virtual void ResetKerberosAuthDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagementPolicy")]
        public virtual void ResetManagementPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOdspInsightDetails")]
        public virtual void ResetOdspInsightDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchOperations")]
        public virtual void ResetPatchOperations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationConfig")]
        public virtual void ResetReplicationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemType")]
        public virtual void ResetSystemType()
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
        = GetStaticProperty<string>(typeof(oci.PsqlDbSystem.PsqlDbSystem))!;

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemInstancesList\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemInstancesList Instances
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemInstancesList>()!;
        }

        [JsiiProperty(name: "instancesDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemInstancesDetailsList\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemInstancesDetailsList InstancesDetails
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemInstancesDetailsList>()!;
        }

        [JsiiProperty(name: "kerberosAuthDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsOutputReference KerberosAuthDetails
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemManagementPolicyOutputReference ManagementPolicy
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemManagementPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemNetworkDetailsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemNetworkDetailsOutputReference NetworkDetails
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemNetworkDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "odspInsightDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemOdspInsightDetailsOutputReference OdspInsightDetails
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemOdspInsightDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemPatchOperationsList\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemPatchOperationsList>()!;
        }

        [JsiiProperty(name: "replicationConfig", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemReplicationConfigOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemReplicationConfigOutputReference ReplicationConfig
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemReplicationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemSourceOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemSourceOutputReference Source
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemSourceOutputReference>()!;
        }

        [JsiiProperty(name: "storageDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemStorageDetailsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemStorageDetailsOutputReference StorageDetails
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemStorageDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "systemRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemTimeoutsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyChangeModeToStandAloneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplyChangeModeToStandAloneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyConfigInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplyConfigInput
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
        [JsiiProperty(name: "configIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentials\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemCredentials? CredentialsInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceMemorySizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceMemorySizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemInstancesDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instancesDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemInstancesDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InstancesDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosAuthDetailsInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails? KerberosAuthDetailsInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementPolicyInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicy\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy? ManagementPolicyInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDetailsInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemNetworkDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemNetworkDetails? NetworkDetailsInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemNetworkDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "odspInsightDetailsInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails? OdspInsightDetailsInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemPatchOperations" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patchOperationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemPatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PatchOperationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationConfigInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemReplicationConfig\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemReplicationConfig? ReplicationConfigInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemReplicationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemSource\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemSource? SourceInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageDetailsInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemStorageDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemStorageDetails? StorageDetailsInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemStorageDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.PsqlDbSystem.IPsqlDbSystemTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applyChangeModeToStandAlone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyChangeModeToStandAlone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applyConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyConfig
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

        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceMemorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceMemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
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

        [JsiiProperty(name: "systemType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
