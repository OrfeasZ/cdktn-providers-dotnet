using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management oci_database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement), fullyQualifiedName: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig\"}}]")]
    public class DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management oci_database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement(Constructs.Construct scope, string id, oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFeatureDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails\"}}]")]
        public virtual void PutFeatureDetails(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFeatureDetails")]
        public virtual void ResetFeatureDetails()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement))!;

        [JsiiProperty(name: "featureDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsOutputReference FeatureDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableExternalNonContainerDbmFeatureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableExternalNonContainerDbmFeatureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalNonContainerDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalNonContainerDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails? FeatureDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enableExternalNonContainerDbmFeature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableExternalNonContainerDbmFeature
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

        [JsiiProperty(name: "externalNonContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalNonContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
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
