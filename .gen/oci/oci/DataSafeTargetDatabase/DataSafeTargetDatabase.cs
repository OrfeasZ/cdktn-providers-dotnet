using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database oci_data_safe_target_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeTargetDatabase.DataSafeTargetDatabase), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConfig\"}}]")]
    public class DataSafeTargetDatabase : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database oci_data_safe_target_database} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeTargetDatabase(Constructs.Construct scope, string id, oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeTargetDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeTargetDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeTargetDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeTargetDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeTargetDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeTargetDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeTargetDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeTargetDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeTargetDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeTargetDatabase.DataSafeTargetDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConnectionOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption\"}}]")]
        public virtual void PutConnectionOption(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseCredentials\"}}]")]
        public virtual void PutCredentials(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetails\"}}]")]
        public virtual void PutDatabaseDetails(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPeerTargetDatabaseDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPeerTargetDatabaseDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTlsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfig\"}}]")]
        public virtual void PutTlsConfig(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionOption")]
        public virtual void ResetConnectionOption()
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

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
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

        [JsiiMethod(name: "resetPeerTargetDatabaseDetails")]
        public virtual void ResetPeerTargetDatabaseDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsConfig")]
        public virtual void ResetTlsConfig()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeTargetDatabase.DataSafeTargetDatabase))!;

        [JsiiProperty(name: "associatedResourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssociatedResourceIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "connectionOption", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOptionOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOptionOutputReference ConnectionOption
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOptionOutputReference>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseCredentialsOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabaseCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabaseCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetailsOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetailsOutputReference DatabaseDetails
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerTargetDatabaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsList\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsList PeerTargetDatabaseDetails
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsList>()!;
        }

        [JsiiProperty(name: "peerTargetDatabases", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabasesList\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabasesList PeerTargetDatabases
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabasesList>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabaseTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabaseTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfigOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfigOutputReference TlsConfig
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionOptionInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption? ConnectionOptionInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseCredentials\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials? CredentialsInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseDetailsInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetails\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails? DatabaseDetailsInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails?>();
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
        [JsiiProperty(name: "peerTargetDatabaseDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PeerTargetDatabaseDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsConfigInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfig\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig? TlsConfigInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig?>();
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
    }
}
