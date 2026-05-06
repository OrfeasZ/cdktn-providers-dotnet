using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDbmulticloudOracleDbAzureBlobContainers
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dbmulticloud_oracle_db_azure_blob_containers oci_dbmulticloud_oracle_db_azure_blob_containers}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainers), fullyQualifiedName: "oci.dataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainers", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersConfig\"}}]")]
    public class DataOciDbmulticloudOracleDbAzureBlobContainers : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dbmulticloud_oracle_db_azure_blob_containers oci_dbmulticloud_oracle_db_azure_blob_containers} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDbmulticloudOracleDbAzureBlobContainers(Constructs.Construct scope, string id, oci.DataOciDbmulticloudOracleDbAzureBlobContainers.IDataOciDbmulticloudOracleDbAzureBlobContainersConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDbmulticloudOracleDbAzureBlobContainers.IDataOciDbmulticloudOracleDbAzureBlobContainersConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDbmulticloudOracleDbAzureBlobContainers(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDbmulticloudOracleDbAzureBlobContainers(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDbmulticloudOracleDbAzureBlobContainers resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDbmulticloudOracleDbAzureBlobContainers to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDbmulticloudOracleDbAzureBlobContainers that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDbmulticloudOracleDbAzureBlobContainers to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDbmulticloudOracleDbAzureBlobContainers to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dbmulticloud_oracle_db_azure_blob_containers#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDbmulticloudOracleDbAzureBlobContainers that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDbmulticloudOracleDbAzureBlobContainers to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainers), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDbmulticloudOracleDbAzureBlobContainers.IDataOciDbmulticloudOracleDbAzureBlobContainersFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDbmulticloudOracleDbAzureBlobContainers.IDataOciDbmulticloudOracleDbAzureBlobContainersFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDbmulticloudOracleDbAzureBlobContainers.IDataOciDbmulticloudOracleDbAzureBlobContainersFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureStorageAccountName")]
        public virtual void ResetAzureStorageAccountName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureStorageContainerName")]
        public virtual void ResetAzureStorageContainerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracleDbAzureBlobContainerId")]
        public virtual void ResetOracleDbAzureBlobContainerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainers))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersFilterList\"}")]
        public virtual oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersFilterList>()!;
        }

        [JsiiProperty(name: "oracleDbAzureBlobContainerSummaryCollection", typeJson: "{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersOracleDbAzureBlobContainerSummaryCollectionList\"}")]
        public virtual oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersOracleDbAzureBlobContainerSummaryCollectionList OracleDbAzureBlobContainerSummaryCollection
        {
            get => GetInstanceProperty<oci.DataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersOracleDbAzureBlobContainerSummaryCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureStorageAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzureStorageAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureStorageContainerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzureStorageContainerNameInput
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
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureBlobContainers.DataOciDbmulticloudOracleDbAzureBlobContainersFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
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
        [JsiiProperty(name: "oracleDbAzureBlobContainerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OracleDbAzureBlobContainerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "azureStorageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureStorageAccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azureStorageContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureStorageContainerName
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "oracleDbAzureBlobContainerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleDbAzureBlobContainerId
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
