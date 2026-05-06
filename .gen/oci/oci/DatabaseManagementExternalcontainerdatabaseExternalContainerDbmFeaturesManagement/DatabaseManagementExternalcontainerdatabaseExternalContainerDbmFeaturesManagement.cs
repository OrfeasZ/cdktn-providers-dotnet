using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management oci_database_management_externalcontainerdatabase_external_container_dbm_features_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement), fullyQualifiedName: "oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementConfig\"}}]")]
    public class DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management oci_database_management_externalcontainerdatabase_external_container_dbm_features_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement(Constructs.Construct scope, string id, oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFeatureDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails\"}}]")]
        public virtual void PutFeatureDetails(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCanDisableAllPdbs")]
        public virtual void ResetCanDisableAllPdbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeature")]
        public virtual void ResetFeature()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement))!;

        [JsiiProperty(name: "featureDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsOutputReference FeatureDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "canDisableAllPdbsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CanDisableAllPdbsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableExternalContainerDbmFeatureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableExternalContainerDbmFeatureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalContainerDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalContainerDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails? FeatureDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "canDisableAllPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object CanDisableAllPdbs
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

        [JsiiProperty(name: "enableExternalContainerDbmFeature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableExternalContainerDbmFeature
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

        [JsiiProperty(name: "externalContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Feature
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
