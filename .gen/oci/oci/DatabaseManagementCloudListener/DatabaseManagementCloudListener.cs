using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudListener
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_listener oci_database_management_cloud_listener}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementCloudListener.DatabaseManagementCloudListener), fullyQualifiedName: "oci.databaseManagementCloudListener.DatabaseManagementCloudListener", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerConfig\"}}]")]
    public class DatabaseManagementCloudListener : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_listener oci_database_management_cloud_listener} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseManagementCloudListener(Constructs.Construct scope, string id, oci.DatabaseManagementCloudListener.IDatabaseManagementCloudListenerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseManagementCloudListener.IDatabaseManagementCloudListenerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementCloudListener(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementCloudListener(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseManagementCloudListener resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseManagementCloudListener to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseManagementCloudListener that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseManagementCloudListener to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseManagementCloudListener to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_listener#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseManagementCloudListener that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseManagementCloudListener to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseManagementCloudListener.DatabaseManagementCloudListener), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseManagementCloudListener.IDatabaseManagementCloudListenerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementCloudListener.IDatabaseManagementCloudListenerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudConnectorId")]
        public virtual void ResetCloudConnectorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseManagementCloudListener.DatabaseManagementCloudListener))!;

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "adrHomeDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdrHomeDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudDbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudDbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudDbNodeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudDbNodeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudDbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbaasId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbaasId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerEndpointsList\"}")]
        public virtual oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerEndpointsList>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerOraLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerOraLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleHome", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleHome
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servicedAsms", typeJson: "{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerServicedAsmsList\"}")]
        public virtual oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerServicedAsmsList ServicedAsms
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerServicedAsmsList>()!;
        }

        [JsiiProperty(name: "servicedDatabases", typeJson: "{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerServicedDatabasesList\"}")]
        public virtual oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerServicedDatabasesList ServicedDatabases
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerServicedDatabasesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudListener.DatabaseManagementCloudListenerTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudConnectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudConnectorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudListenerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudListenerIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseManagementCloudListener.DatabaseManagementCloudListenerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cloudConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudConnectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudListenerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudListenerId
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
    }
}
