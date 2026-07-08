using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global oci_database_tools_runtime_database_tools_database_api_gateway_config_global}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global oci_database_tools_runtime_database_tools_database_api_gateway_config_global} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCertificateBundle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle\"}}]")]
        public virtual void PutCertificateBundle(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdvancedProperties")]
        public virtual void ResetAdvancedProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateBundle")]
        public virtual void ResetCertificateBundle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseApiStatus")]
        public virtual void ResetDatabaseApiStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentRoot")]
        public virtual void ResetDocumentRoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpPort")]
        public virtual void ResetHttpPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpsPort")]
        public virtual void ResetHttpsPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolRoute")]
        public virtual void ResetPoolRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolRoutingHeader")]
        public virtual void ResetPoolRoutingHeader()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal))!;

        [JsiiProperty(name: "certificateBundle", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference CertificateBundle
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadataSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedPropertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdvancedPropertiesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateBundleInput", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle? CertificateBundleInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseApiStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseApiStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsDatabaseApiGatewayConfigIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentRootInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentRootInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GlobalKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpsPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolRouteInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolRouteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolRoutingHeaderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolRoutingHeaderInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdvancedProperties
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseApiStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseApiStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentRoot
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpsPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolRoute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRoute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolRoutingHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRoutingHeader
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
