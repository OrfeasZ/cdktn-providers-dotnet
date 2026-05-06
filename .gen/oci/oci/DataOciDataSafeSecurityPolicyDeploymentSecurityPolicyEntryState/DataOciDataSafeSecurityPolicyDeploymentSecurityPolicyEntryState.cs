using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_policy_deployment_security_policy_entry_state oci_data_safe_security_policy_deployment_security_policy_entry_state}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState), fullyQualifiedName: "oci.dataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryStateConfig\"}}]")]
    public class DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_policy_deployment_security_policy_entry_state oci_data_safe_security_policy_deployment_security_policy_entry_state} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.IDataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryStateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.IDataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryStateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_policy_deployment_security_policy_entry_state#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState))!;

        [JsiiProperty(name: "deploymentStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentStatusDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentStatusDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entryDetails", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryStateEntryDetailsList\"}")]
        public virtual oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryStateEntryDetailsList EntryDetails
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryState.DataOciDataSafeSecurityPolicyDeploymentSecurityPolicyEntryStateEntryDetailsList>()!;
        }

        [JsiiProperty(name: "entryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityPolicyEntryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicyEntryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityPolicyDeploymentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityPolicyDeploymentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityPolicyEntryStateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityPolicyEntryStateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityPolicyDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicyDeploymentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityPolicyEntryStateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicyEntryStateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
