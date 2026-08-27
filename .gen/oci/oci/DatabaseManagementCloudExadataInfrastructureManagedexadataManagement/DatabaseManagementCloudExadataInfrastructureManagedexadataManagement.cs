using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management oci_database_management_cloud_exadata_infrastructure_managedexadata_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement), fullyQualifiedName: "oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig\"}}]")]
    public class DatabaseManagementCloudExadataInfrastructureManagedexadataManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management oci_database_management_cloud_exadata_infrastructure_managedexadata_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseManagementCloudExadataInfrastructureManagedexadataManagement(Constructs.Construct scope, string id, oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementCloudExadataInfrastructureManagedexadataManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementCloudExadataInfrastructureManagedexadataManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseManagementCloudExadataInfrastructureManagedexadataManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseManagementCloudExadataInfrastructureManagedexadataManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseManagementCloudExadataInfrastructureManagedexadataManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseManagementCloudExadataInfrastructureManagedexadataManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseManagementCloudExadataInfrastructureManagedexadataManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_management_cloud_exadata_infrastructure_managedexadata_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseManagementCloudExadataInfrastructureManagedexadataManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseManagementCloudExadataInfrastructureManagedexadataManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseModel")]
        public virtual void ResetLicenseModel()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudExadataInfrastructureIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableManagedexadataInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableManagedexadataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseManagementCloudExadataInfrastructureManagedexadataManagement.IDatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseManagementCloudExadataInfrastructureManagedexadataManagement.DatabaseManagementCloudExadataInfrastructureManagedexadataManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableManagedexadata", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableManagedexadata
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
